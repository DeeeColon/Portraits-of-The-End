using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;

// code for dialogue trigger is referenced from:
// Title: How to make a Dialogue System with Choices in Unity2D | Unity + Ink tutorial 
// Author: Shaped by Rain Studios
// Date: 5/7/2025
// Availability: https://youtu.be/vY0Sk93YUhA?si=H7jIWgzF2tr9MRC0



public class dialogueTrigger : MonoBehaviour
{
   [Header("Ink JSON")]
   [SerializeField] private TextAsset inkJSON;
   
   public void OpenDialogue()
   {
      dialogueManager.GetInstance().EnterDialogueMode(inkJSON);
      Debug.Log("Dialogue Entered!");
   }
   
   
   
}