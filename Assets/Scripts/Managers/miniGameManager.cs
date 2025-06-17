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
    
    public TextMeshProUGUI winText;
    public GameObject EndOFDateBox;

    public GameObject FirstDifficulty;
    public GameObject TIMER;
    public GameObject MiniGameOne;
    public GameObject MiniGameTwo;
    public GameObject MiniGameThree;
    public timerScript timer;
    [SerializeField] private ScoreCommunicator DateScore;
    [SerializeField] private DateChecker DateChecker;
   

    public GameObject bottles;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PointsToWinMiniGameOne = 6;
        Chopped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPointsMiniGameOne == PointsToWinMiniGameOne)
        {
            MiniGameOne.SetActive(false);
            MiniGameTwo.SetActive(true);
            Debug.Log("Changed Mini Game One");
        }
        if (MiniGameThreePoints == 500)
        {
            tasksCompleted = true;

        }

        if (Chopped)
        {
            MiniGameTwo.SetActive(false);
            MiniGameThree.SetActive(true);
            Chopped = false;
            
        }

        if (tasksCompleted && timer.getRemainingTime() >= 0)
        {
            MiniGameWon();
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
        currentPointsMiniGameOne++;
        Debug.Log("added a point");
        Debug.Log(currentPointsMiniGameOne);
    }
    

    public void ScrubbingPoints()
    {
        MiniGameThreePoints++;
    }

    public void Chop()
    {
        Chopped = true;
    }
    
    public void MiniGameWon()
    {
        TIMER.SetActive(false);
        EndOFDateBox.SetActive(true);
        FirstDifficulty.SetActive(false);
        DateScore.Value += 3;
        if (DateScore.Value >= 4)
        {
            winText.text = "Successful Date! You did well.";
            DateChecker.SiennaDateComplete();
            DateChecker.SiennaDateSucceeded();
            
        } 
        else if (DateScore.Value == 4)
        {
            winText.text = "Successful Date! You did okay.";
            DateChecker.SiennaDateComplete();
            DateChecker.SiennaDateSucceeded();
        } 
        else if (DateScore.Value <= 4)
        {
            winText.text = "Unsuccessful Date! You did not do well.";
            DateChecker.SiennaDateComplete();
        }
        
    }

    public void MiniGameLost()
    {
        TIMER.SetActive(false);
        EndOFDateBox.SetActive(true);
        FirstDifficulty.SetActive(false);
        if (DateScore.Value >= 4)
        {
            winText.text = "Successful Date! You did well.";
            DateChecker.SiennaDateComplete();
            DateChecker.SiennaDateSucceeded();
        } 
        else if (DateScore.Value == 4)
        {
            winText.text = "Successful Date! You did okay.";
            DateChecker.SiennaDateComplete();
            DateChecker.SiennaDateSucceeded();
        } 
        else if (DateScore.Value <= 4)
        {
            winText.text = "Unsuccessful Date! You did not do well.";
            DateChecker.SiennaDateComplete();
        }
        
    }
    
}
