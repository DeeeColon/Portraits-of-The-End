using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// code for dialogue is referenced from:

// Title: Create DIALOGUE system for your game | Unity tutorial
// Author: Coco Code
// Date: 18 April 2025
// Availability: https://youtu.be/PswC-HIKZqA?si=puzCaebHxaYuC6EY


public class DialogueTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;

    public DialogueManagement targetScript;

    public void StartDialogue()
    {
        FindAnyObjectByType<DialogueManagement>().OpenDialogue(messages, actors);
    }
}

[System.Serializable]
public class Message
{
    public int actorId;
    public string message;
}

[System.Serializable]
public class Actor
{
    public string name;
    public Sprite sprite;
}

