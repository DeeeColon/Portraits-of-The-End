using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class choiceButtonScript : MonoBehaviour
{
  public TextMeshProUGUI winText;
    void start()
    {
      
    }

    int answerScore = 0;
    bool dateSuccess = false;
    


    public void OptionOne()
    {
        answerScore += 1;
        Debug.Log("Added 1 to the score!");

    }

    public void OptionTwo()
    {
        answerScore += 2;
        Debug.Log("Added 2 to the score!");
    }

    public void OptionThree()
    {
        answerScore += 3;
        Debug.Log("Added 3 to the score!");
    }

    public void printValue()
    {
        print(answerScore);
    }

    

    public void DateEndChecker()
    {
      if (answerScore >= 2)
      {
        dateSuccess = true;
        print("You have won!");
        winText.text = "Successful Date!";
      } else
      {
        dateSuccess = false;
        print("You have lost!");
        winText.text = "Unsuccessful Date!";
      }
    }
    
}
