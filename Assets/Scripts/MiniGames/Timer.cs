using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class Timer : MonoBehaviour
{
    public Image timerBar;
    public float maxTime = 7f;
    public float timeLeft;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
