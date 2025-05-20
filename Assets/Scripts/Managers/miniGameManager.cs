using UnityEngine;

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
    private int Hearts;
    
    public GameObject MiniGameOne;
    public GameObject MiniGameTwo;
    public GameObject MiniGameThree;

    public GameObject bottles;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PointsToWinMiniGameOne = bottles.transform.childCount;
        Hearts = 3;
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
        if (MiniGameThreePoints == 300)
        {
            MiniGameThree.SetActive(false);
            MiniGameOne.SetActive(true);
        }

        if (Chopped)
        {
            MiniGameTwo.SetActive(false);
            MiniGameThree.SetActive(true);
            
        }

        if (MiniGameThree.activeSelf)
        {
            Chopped = false;
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
    
    
}
