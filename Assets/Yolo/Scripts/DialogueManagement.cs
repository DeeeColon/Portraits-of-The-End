using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using System;

// code for dialogue is referenced from:

// Title: Create DIALOGUE system for your game | Unity tutorial
// Author: Coco Code
// Date: 18 April 2025
// Code Version: (ask tutors about this)
// Availability: https://youtu.be/PswC-HIKZqA?si=puzCaebHxaYuC6EY


public class DialogueManagement : MonoBehaviour
{

   
   
    public Image actorImage;
    public Text actorName;
    public Text messageText;
    public RectTransform backgroundBox;

    Message [] currentMessages;
    Actor [] currentActors;
    int activeMessage = 0;
    public static bool isActive = false;
    

    public void OpenDialogue(Message[] messages, Actor[] actors)
    {
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
       

        Debug.Log("Started conversation! Loaded messages: " + messages.Length);
        DisplayMessage();
    }

    void DisplayMessage()
    {
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.message;

        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorToDisplay.name;
        actorImage.sprite = actorToDisplay.sprite;

    }

    public void NextMessage()
    {
        activeMessage++;
        if (activeMessage < currentMessages.Length)
        {
            DisplayMessage();
        } else
        {
            Debug.Log("Conversation Ended!");
            isActive = false;
        }
    }

 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isActive == true)
        {
            NextMessage();
        }
    }
}
