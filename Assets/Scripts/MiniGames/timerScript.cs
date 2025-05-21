using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    public static timerScript instance;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;
    public bool timerStopped;

    public float getRemainingTime()
    {
        return remainingTime;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerStopped) return;
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime < 0)
        {
            remainingTime = 0;
            
        }
        
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (remainingTime <= 0)
        {
            miniGameManager.instance.MiniGameLost();
        }
    }
    
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void StopTimer()
    {
        if (remainingTime <= 0)
        {
            timerStopped = true;
        }
    }
}
