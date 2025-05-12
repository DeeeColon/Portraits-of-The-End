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
   [Header("Dialogue UI")] 
   [SerializeField] private GameObject dialoguePanel;
   [SerializeField] private TextMeshProUGUI dialogueText;
   
   [Header("Choices UI")]
   [SerializeField] private GameObject[] choices;
   private TextMeshProUGUI[] choicesText;
   
   private Story currentStory;
   private bool dialogueActive;
   
   private static dialogueManager instance;

   private void Awake()
   {
      if (instance != null)
      {
         Debug.LogError("More than one dialogue manager found");
      }
      instance = this;
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

      if (Input.GetKeyDown(KeyCode.Space))
      {
         ContinueStory();
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
   }

   private void ContinueStory()
   {
      if (currentStory.canContinue)
      {
         dialogueText.text = currentStory.Continue();
         DisplayChoices();
      }
      else
      {
         ExitDialogueMode();
      }
   }

   private void DisplayChoices()
   {
      List<Choice> currentChoices = currentStory.currentChoices;

      if (currentChoices.Count > choices.Length)
      {
         Debug.LogError("More choices were given than the UI can support. Number of choices given: " + currentChoices.Count);
      }
      
      int index = 0;
      foreach (Choice choice in currentChoices)
      {
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
      currentStory.ChooseChoiceIndex(choiceIndex);
   }



}
