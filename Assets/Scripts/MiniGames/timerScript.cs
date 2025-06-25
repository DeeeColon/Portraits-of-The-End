using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    public static timerScript instance;
    [SerializeField] Slider timerSlider;
    [SerializeField] public miniGameManager MiniGameManager;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] Image timerImage;
    [SerializeField] private GameObject sliderBar;
    [SerializeField] private Image timerBar;
    [SerializeField] float remainingTime;
    public bool timerStopped;
    [SerializeField] private MiniGameCommunicator NewMiniGameCommunicator;

    public float getRemainingTime()
    {
        return remainingTime;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerSlider.value = remainingTime;
        timerSlider.maxValue = remainingTime;
    }

    // Update is called once per frame
    void Update()
    {
        timerSlider.value = remainingTime;

        if (remainingTime <= 31 && remainingTime >= 16)
        {
            
            LeanTween.color(timerBar.rectTransform, Color.yellow, 1f);
        } 
        else if (remainingTime <= 16)
        {
            LeanTween.color(timerBar.rectTransform, Color.red, 1f);
        }
        
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
            NewMiniGameCommunicator.TimeHasEnded = true;

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
