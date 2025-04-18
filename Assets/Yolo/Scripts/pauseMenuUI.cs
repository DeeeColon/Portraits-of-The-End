using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenuUI : MonoBehaviour
{
    public void mainMenuBTN()
    {
        SceneManager.LoadScene("mainMenuScene");
    }

    public void ExitBTN()
    {
        Application.Quit();
    }
}
