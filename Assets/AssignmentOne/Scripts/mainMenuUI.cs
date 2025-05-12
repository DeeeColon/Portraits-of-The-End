using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// code for loading scene is referenced from:
// Title: Load a scene in Unity from a button!
// Author: RigorMortisTortoise
// Date: 17 April 2025
// Availability https://youtube.com/shorts/qCKmtlKmRyQ?si=ho4moXh2v9St8vYt

public class mainMenuUI : MonoBehaviour
{

    public void startGameBTN()
    {
        SceneManager.LoadScene("mapDaytimeScene");
    }

// Code for exit button is referenced from:
// Title: MAIN MENU in Unity (Best Menu Tutorial 2024)
// Author: SpeedTutor
// Date: 17 April 2025
// Availability: https://youtu.be/Cq_Nnw_Lmnl?si6_3a7wW6jbYKRq_d

    public void ExitBTN()
    {
        Application.Quit();
    }


}
