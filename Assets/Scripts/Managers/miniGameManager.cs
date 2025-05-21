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
    private int PointsToWinMiniGameOne;
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
    public dialogueManager dialogueManager;
   

    public GameObject bottles;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PointsToWinMiniGameOne = bottles.transform.childCount;
        Chopped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPointsMiniGameOne >= PointsToWinMiniGameOne)
        {
            MiniGameOne.SetActive(false);
            MiniGameTwo.SetActive(true);
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
        dialogueManager = GameObject.Find("DialogueManager").GetComponent<dialogueManager>();
        timer = GameObject.Find("TIMER").GetComponent<timerScript>();
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
        dialogueManager.SuccessfulMiniGame();
        if (dialogueManager.getDialogueScore() >= 4)
        {
            winText.text = "Successful Date! You did well.";
        } 
        else if (dialogueManager.getDialogueScore() == 4)
        {
            winText.text = "Successful Date! You did okay.";
        } 
        else if (dialogueManager.getDialogueScore() <= 4)
        {
            winText.text = "Unsuccessful Date! You did not do well.";
        }
        
    }

    public void MiniGameLost()
    {
        TIMER.SetActive(false);
        EndOFDateBox.SetActive(true);
        FirstDifficulty.SetActive(false);
        if (dialogueManager.getDialogueScore() >= 4)
        {
            winText.text = "Successful Date! You did well.";
        } 
        else if (dialogueManager.getDialogueScore() == 4)
        {
            winText.text = "Successful Date! You did okay.";
        } 
        else if (dialogueManager.getDialogueScore() <= 4)
        {
            winText.text = "Unsuccessful Date! You did not do well.";
        }
        
    }
    
}
