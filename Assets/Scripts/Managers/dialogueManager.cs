using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using Ink.Parsed;
using Ink.Runtime;
using Choice = Ink.Runtime.Choice;
using Story = Ink.Runtime.Story;
using UnityEngine.EventSystems;

// code for dialogue manager is referenced from:
// Title: How to make a Dialogue System with Choices in Unity2D | Unity + Ink tutorial 
// Author: Shaped by Rain Studios
// Date: 5/7/2025
// Availability: https://youtu.be/vY0Sk93YUhA?si=H7jIWgzF2tr9MRC0
public class dialogueManager : MonoBehaviour
{
   [Header("Dialogue UI")] [SerializeField]
   private GameObject dialoguePanel;

   private GameObject Managers;

   [SerializeField] private TextMeshProUGUI dialogueText;
   [SerializeField] private TextMeshProUGUI displayNameText;
   [SerializeField] private Animator portraitAnimator;
   [SerializeField] private TextMeshProUGUI playerPrompter;


   [Header("Choices UI")] [SerializeField]
   private GameObject[] choices;

   private TextMeshProUGUI[] choicesText;

   private Story currentStory;
   private bool dialogueActive;
   private bool isPaused;
   private int dateScore;

   private static dialogueManager instance;

   private const string SPEAKER_TAG = "Speaker";

   private const string PORTRAIT_TAG = "Portrait";

   private const string LAYOUT_TAG = "Layout";
   
   private const string CHOICE_TAG = "Choice";

   private void Awake()
   {
      if (instance != null)
      {
         Debug.LogError("More than one dialogue manager found");
      }

      instance = this;
      Managers = GameObject.Find("Managers");
      DontDestroyOnLoad(Managers);
   }

   public static dialogueManager GetInstance()
   {
      return instance;
   }

   private void Start()
   {
      dialoguePanel.SetActive(false);
      dialogueActive = false;

      choicesText = new TextMeshProUGUI[choices.Length];
      int index = 0;
      foreach (GameObject choice in choices)
      {
         choicesText[index] = choice.GetComponentInChildren<TextMeshProUGUI>();
         index++;
      }
   }

   private void Update()
   {
      if (!dialogueActive)
      {
         return;
      }

   }

   public void EnterDialogueMode(TextAsset inkJSON)
   {
      currentStory = new Story(inkJSON.text);
      dialogueActive = true;
      dialoguePanel.SetActive(true);

      ContinueStory();


   }

   private void ExitDialogueMode()
   {
      dialoguePanel.SetActive(false);
      dialogueActive = false;
      dialogueText.text = "";
      if (dateScore >= 4)
      {
         print("successful date!");
      }
      else
      {
         print("failed date!");
      }
   }

   private void ContinueStory()
   {
      if (currentStory.canContinue)
      {
         playerPrompter.text = "Press Click The Arrow To Continue";
         dialogueText.text = currentStory.Continue();
         DisplayChoices();
         HandleTags(currentStory.currentTags);
      }
      else
      {
         // this is different for some reason, check out later
         ExitDialogueMode();
      }
   }

   private void HandleTags(List<string> currentTags)
   {
      foreach (string tag in currentTags)
      {
         string[] splitTag = tag.Split(':');
         if (splitTag.Length != 2)
         {
            Debug.LogError("Tag could not be appropriately parsed: " + tag);
         }

         string tagKey = splitTag[0].Trim();
         string tagValue = splitTag[1].Trim();

         switch (tagKey)
         {
            case SPEAKER_TAG:
               Debug.Log("speaker= " + tagValue);
               displayNameText.text = tagValue;
               break;
            case PORTRAIT_TAG:
               Debug.Log("portrait= " + tagValue);
               portraitAnimator.Play(tagValue);
               break;
            case LAYOUT_TAG:
               Debug.Log("layout= " + tagValue);
               break;
            case CHOICE_TAG:
               Debug.Log("choice= " + tagValue);
               if (tagValue == "good")
               {
                  print("good choice");
                  dateScore+= 2;
               } else if (tagValue == "great")
               {
                  print("great choice");
                  dateScore+= 3;
               } else if (tagValue == "bad")
               {
                  print("bad choice");
                  dateScore += 1;
               }
               break;
            default:
               Debug.LogWarning("Tag had came in but not implemented: " + tag);
               break;
         }
      }
   }

   private void DisplayChoices()
   {
      List<Choice> currentChoices = currentStory.currentChoices;

      if (currentChoices.Count > choices.Length)
      {
         Debug.LogError("More choices were given than the UI can support. Number of choices given: " +
                        currentChoices.Count);
      }

      int index = 0;
      foreach (Choice choice in currentChoices)
      {
         isPaused = true;
         playerPrompter.text = "Please Select An Option";
         
         choices[index].gameObject.SetActive(true);
         choicesText[index].text = choice.text;
         index++;
      }

      for (int i = index; i < choices.Length; i++)
      {
         choices[i].gameObject.SetActive(false);
      }

      StartCoroutine(SelectFirstChoice());
   }

   private IEnumerator SelectFirstChoice()
   {
      EventSystem.current.SetSelectedGameObject(null);
      yield return new WaitForEndOfFrame();
      EventSystem.current.SetSelectedGameObject(choices[0].gameObject);
   }

   public void MakeChoice(int choiceIndex)
   {
      isPaused = false;
      currentStory.ChooseChoiceIndex(choiceIndex);
      playerPrompter.text = "Press Click The Arrow To Continue";
   }

   public void ChoiceStoryAdvancer()
   {
      ContinueStory();
   }

   public void Paused()
   {
      isPaused = true;
   }

   public void Unpaused()
   {
      isPaused = false;
   }

   public float getDialogueScore()
   {
      return dateScore;
   }

   public void SuccessfulMiniGame()
   {
      dateScore += 3;
   }
}