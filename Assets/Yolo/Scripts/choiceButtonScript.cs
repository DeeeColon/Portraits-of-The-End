using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class choiceButtonScript : MonoBehaviour
{

    int answerScore = 0;
    bool dateSuccess = false;
   


    public void OptionOne()
    {
        answerScore += 1;
    }

    public void OptionTwo()
    {
        answerScore += 2;
    }

    public void OptionThree()
    {
        answerScore += 3;
    }

    public void printValue()
    {
        print(answerScore);
    }

    

    public void DateEndChecker()
    {
      if (answerScore >= 5)
      {
        dateSuccess = true;
        print("You have won!");
      } else
      {
        dateSuccess = false;
        print("You have lost!");
      }
    }
    
}
