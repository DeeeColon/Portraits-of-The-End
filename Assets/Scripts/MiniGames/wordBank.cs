using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

/*
code for word bank is from:
Title: Basic Typing Game with Unity [02]
Author: VR with Andrew
Date: 10/6/2020
Availability: https://youtu.be/tdXXW0ln_LU?si=ew3OddOVDafOACyX
*/
public class wordBank : MonoBehaviour
{
   private List<string> originalWords = new List<string>()
   {
      "Pancakes", "Are", "Delicious"
   };
   private List<string> workingWords = new List<string>();

   private void awake()
   {
      workingWords.AddRange(originalWords);
      Shuffle(workingWords);
      ConvertToLower(workingWords);
   }

   private void Shuffle(List<string> list)
   {
      for (int i = 0; i < list.Count; i++)
      {
         int random = Random.Range(i, list.Count);
         string temporary = list[i];
         
         list[i] = list[random];
         list[random] = temporary;
      }
   }

   private void ConvertToLower(List<string> list)
   {
      for (int i = 0; i < list.Count; i++)
         list[i] = list[i].ToLower();
   }

   public string GetWord()
   {
      string newWord = string.Empty;

      if (workingWords.Count > 0)
      {
         newWord = workingWords.Last();
         workingWords.Remove(newWord);
         
      }
      return newWord;
   }
}
