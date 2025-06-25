using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
/*
code for Typer.cs came from
Title: Basic Typing Game with Unity [01] 
Author: VR with Andrew
Date: 3/06/2020
Availability: https://youtu.be/j98a_X9G1fM?si=i6t8-rz-a_UmWrG9 
*/

public class Typer : MonoBehaviour
{
    public wordBank wordBank;
    public TextMeshProUGUI WordOutput = null;
    public int score = 0;
    public GameObject miniGameTwo;
    [SerializeField] private MiniGameCommunicator NewMiniGameCommunicator;

    private string RemainingWord = string.Empty;
    private string CurrentWord = string.Empty;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        SetCurrentWord();
        NewMiniGameCommunicator.TypingScore = 0;
    }

    private void SetCurrentWord()
    {
        CurrentWord = wordBank.GetWord();
        SetRemainingWord(CurrentWord);
    }

    private void SetRemainingWord(string newString)
    {
        RemainingWord = newString;
        WordOutput.text = RemainingWord;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        
    }

    private void CheckInput()
    {
        if (Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;
            if (keysPressed.Length == 1)
            {
                EnterLetter(keysPressed);
            }
        }
    }

    private void EnterLetter(string typedLetter)
    {
        if (isCorrectLetter(typedLetter))
        {
          RemoveLetter();
          if (isWordComplete())
          { 
              SetCurrentWord();
              NewMiniGameCommunicator.TypingScore++;

          }
              
        }
    }

    private bool isCorrectLetter(string letter)
    {
        return RemainingWord.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString = RemainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }

    private bool isWordComplete()
    {
        return RemainingWord.Length == 0;
    }
}
