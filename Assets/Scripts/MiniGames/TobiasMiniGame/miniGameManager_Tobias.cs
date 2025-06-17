using UnityEngine;

public class miniGameManager_Tobias : MonoBehaviour
{
    public static  miniGameManager_Tobias instance;
    [SerializeField] private GameObject MiniGames;
    [SerializeField] private GameObject miniGameOne;
    [SerializeField] private GameObject miniGameTwo;
    [SerializeField] private GameObject miniGameThree;
    [SerializeField] private GameObject TIMER;

    [SerializeField] private GameObject winText;
    public timerScript timer;
    public dialogueManager dialogueManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
    
    public void MiniGameWon()
    {
        TIMER.SetActive(false);
        MiniGames.SetActive(false);
        dialogueManager.SuccessfulMiniGame();
        if (dialogueManager.getDialogueScore() >= 4)
        {
            Debug.Log("You Win!, Well Done!");
        } 
        else if (dialogueManager.getDialogueScore() == 4)
        {
            Debug.Log("You Win!");
        } 
        else if (dialogueManager.getDialogueScore() <= 4)
        {
            Debug.Log("You Lose!");
        }
        
    }
    
    public void MiniGameLost()
    {
        TIMER.SetActive(false);
        MiniGames.SetActive(false);
        if (dialogueManager.getDialogueScore() >= 4)
        {
            Debug.Log(" You Win!");
        } 
        else if (dialogueManager.getDialogueScore() == 4)
        {
            Debug.Log(" You Win");
        } 
        else if (dialogueManager.getDialogueScore() <= 4)
        {
           Debug.Log("You Lose!"); 
        }
        
    }

    public void MiniGameOneWin()
    {
        miniGameOne.SetActive(false);
        miniGameTwo.SetActive(true);
    }

    public void MiniGameTwoWin()
    {
        miniGameTwo.SetActive(false);
        miniGameThree.SetActive(true);
    }

    public void MiniGameThreeWin()
    {
        miniGameThree.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
