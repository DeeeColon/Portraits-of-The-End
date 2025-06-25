using UnityEngine;
using UnityEngine.UI;

public class DateChecker : MonoBehaviour
{
	
   

    public GameObject tobiasPortrait;
    public GameObject siennaPortrait;

    public Button Cafe;
    public Button SiennasBar;
    [SerializeField] private ScoreCommunicator DateScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SiennaDateComplete()
    {
        DateScore.SiennaDateOneCompleted = true;
    }

    public void TobiasDateComplete()
    {
        DateScore.TobiasDateOneCompleted = true;
    }

    public void SiennaDateSucceeded()
    {
        DateScore.SiennaDateOneSuccess =  true;
    }

    public void TobiasDateSucceeded()
    {
        DateScore.TobiasDateOneSuccess = true;
    }

    public void RESET()
    {
        DateScore.SiennaDateOneCompleted = false;
        DateScore.TobiasDateOneCompleted = false;
        DateScore.SiennaDateOneSuccess = false;
        DateScore.TobiasDateOneSuccess = false;
    }
    
    
    
}
