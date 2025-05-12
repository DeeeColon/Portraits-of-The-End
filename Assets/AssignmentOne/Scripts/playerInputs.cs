using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class playerInputs : MonoBehaviour
{
    // code for mouse button input is referenced from:
    // Title: Basic Mouse Inputs In Unity
    // Author: Game Dev By Kaupenjoe
    // Date: 18 April 2025
    // Code Version: (ask lecturers about this)
    // Availability: https://youtu.be/fE4bRxo1X_4?si=SWy6o7YwedJMVeml 


   void Update()
   {
    if(Input.GetMouseButtonDown(0))
    {
        Debug.Log("Left Clicked!");
        Debug.Log("Mouse Position "+ Input.mousePosition);
    }

    if(Input.GetMouseButton(1))
    {
        Debug.Log("Right Clicked!");
    }

    if(Input.GetMouseButtonUp(2))
    {
        Debug.Log("Middle Button Clicked!");
    }


   }



}
