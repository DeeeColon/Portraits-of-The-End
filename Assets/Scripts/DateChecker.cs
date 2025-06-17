using UnityEngine;
using UnityEngine.UI;

public class DateChecker : MonoBehaviour
{
    public bool SiennaDateOneSuccess = false;
    public bool TobiasDateOneSuccess = false;
    public bool SiennaDateOneCompleted = false;
    public bool TobiasDateOneCompleted = false;

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
        SiennaDateOneCompleted = true;
    }

    public void TobiasDateComplete()
    {
        TobiasDateOneCompleted = true;
    }

    public void SiennaDateSucceeded()
    {
        SiennaDateOneSuccess =  true;
    }

    public void TobiasDateSucceeded()
    {
        TobiasDateOneSuccess = true;
    }

    public void RESET()
    {
        SiennaDateOneCompleted = false;
        TobiasDateOneCompleted = false;
        SiennaDateOneSuccess = false;
        TobiasDateOneSuccess = false;
    }
    
    
    
}
