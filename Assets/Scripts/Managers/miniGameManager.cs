using UnityEngine;
using TMPro;

// code for minigameone is referenced from:
// Title: Drag and Drop System in Unity - Puzzle Game Example (PC and Mobile)
// Author: GameDevel
// Date: 5 April 2020
// Availability: https://youtu.be/uk_E_cGrlQc?si=BT9XZij2Pe2rxJJO
public class miniGameManager : MonoBehaviour
{
    public static miniGameManager instance;
    public int PointsToWinMiniGameOne;
    private int currentPointsMiniGameOne;
    private int MiniGameThreePoints;
    private bool Chopped;
    private int Difficulty;
    private bool tasksCompleted;
    
    public TextMeshProUGUI prompter;
    public GameObject EndOFDateBox;
    public GameObject WinBox;
    public GameObject LoseBox;

    public GameObject FirstDifficulty;
    public GameObject TIMER;
    public GameObject MiniGameOne;
    public GameObject MiniGameTwo;
    public GameObject MiniGameThree;
    public timerScript timer;
    [SerializeField] private ScoreCommunicator DateScore;
    [SerializeField] private DateChecker DateChecker;
    [SerializeField] private MiniGameCommunicator NewMiniGameCommunicator;
   

    public GameObject bottles;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PointsToWinMiniGameOne = 6;
        NewMiniGameCommunicator.Chopped = false;
        NewMiniGameCommunicator.MiniGameThreePoints = 0;
        NewMiniGameCommunicator.currentPointsMiniGameOne = 0;
        NewMiniGameCommunicator.TimeHasEnded = false;
        prompter.text = "Use The Mouse To Sort Out The Bottles!";
    }

    // Update is called once per frame
    void Update()
    {
        if (NewMiniGameCommunicator.currentPointsMiniGameOne == PointsToWinMiniGameOne)
        {
            prompter.text = "Press Space to Chop The Lemon!";
            MiniGameOne.SetActive(false);
            MiniGameTwo.SetActive(true);
        }
        if (NewMiniGameCommunicator.MiniGameThreePoints == 500)
        {
            tasksCompleted = true;

        }

        if (NewMiniGameCommunicator.Chopped)
        {
            prompter.text = "Move the Mouse Up and Down to Clean!";
            MiniGameTwo.SetActive(false);
            MiniGameThree.SetActive(true);
            NewMiniGameCommunicator.Chopped = false;
            
        }

        if (tasksCompleted && NewMiniGameCommunicator.TimeHasEnded == false)
        {
            Debug.Log("MiniGameWon");
            MiniGameWon();
        }

        if (NewMiniGameCommunicator.TimeHasEnded == true)
        {
            MiniGameLost();
            Debug.Log("MiniGameLost");
        }
    }

    private void Awake()
    {
        timer = GameObject.Find("TIMER").GetComponent<timerScript>();
        DateChecker =  GameObject.Find("DateChecker").GetComponent<DateChecker>();
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void AddPoints()
    {
        NewMiniGameCommunicator.currentPointsMiniGameOne++;
        Debug.Log("added a point");
        Debug.Log(NewMiniGameCommunicator.currentPointsMiniGameOne);
    }
    

    public void ScrubbingPoints()
    {
        NewMiniGameCommunicator.MiniGameThreePoints++;
    }

    public void Chop()
    {
        NewMiniGameCommunicator.Chopped = true;
    }
    
    public void MiniGameWon()
    {
        
        TIMER.SetActive(false);
        EndOFDateBox.SetActive(true);
        FirstDifficulty.SetActive(false);
        DateScore.Value += 3;
        if (DateScore.Value >= 4)
        {
            Debug.Log("Successful Date! You did well.");
            DateChecker.SiennaDateComplete();
            DateChecker.SiennaDateSucceeded();
            WinBox.SetActive(true);
            
        } 
        else if (DateScore.Value == 4)
        {
            Debug.Log("Successful Date! You did okay.");
            DateChecker.SiennaDateComplete();
            DateChecker.SiennaDateSucceeded();
            WinBox.SetActive(true);
        } 
        else if (DateScore.Value <= 4)
        {
            Debug.Log("Unsuccessful Date! You did not do well."); 
            DateChecker.SiennaDateComplete();
            LoseBox.SetActive(true);
        }
        
    }

    public void MiniGameLost()
    {
        
        TIMER.SetActive(false);
        EndOFDateBox.SetActive(true);
        FirstDifficulty.SetActive(false);
        if (DateScore.Value >= 4)
        {
            DateChecker.SiennaDateComplete();
            DateChecker.SiennaDateSucceeded();
            WinBox.SetActive(true);
        } 
        else if (DateScore.Value == 4)
        {
            DateChecker.SiennaDateComplete();
            DateChecker.SiennaDateSucceeded();
            WinBox.SetActive(true);
        } 
        else if (DateScore.Value <= 4)
        {
            
            DateChecker.SiennaDateComplete();
            LoseBox.SetActive(true);
        }
        
    }
    
}
