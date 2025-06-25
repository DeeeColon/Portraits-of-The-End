using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class miniGameManager_Tobias : MonoBehaviour
{
    public static  miniGameManager_Tobias instance;
    [SerializeField] private GameObject MiniGames;
    [SerializeField] private GameObject miniGameOne;
    [SerializeField] private GameObject miniGameTwo;
    [SerializeField] private GameObject miniGameThree;
    [SerializeField] private GameObject TIMER;
    [SerializeField] private MiniGameCommunicator NewMiniGameCommunicator;
    [SerializeField] private DateChecker DateChecker;
    [SerializeField] private ScoreCommunicator DateScore;
    [SerializeField] private TextMeshProUGUI GamePrompter;
    
    [SerializeField] public GameObject EndOFDateBox;
    [SerializeField] public GameObject WinBox;
    [SerializeField] public GameObject LoseBox;

    [SerializeField] private GameObject winText;
    public timerScript timer;
    public bool gamesCompleted;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NewMiniGameCommunicator.TypingScore = 0;
        NewMiniGameCommunicator.CurrentSlotPoints = 0;
        NewMiniGameCommunicator.PapersCaught = 0;
        NewMiniGameCommunicator.TimeHasEnded = false;
        gamesCompleted = false;
        GamePrompter.text = "Type Out The Email!";
    }

    private void Awake()
    {
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
        EndOFDateBox.SetActive(true);
        TIMER.SetActive(false);
        MiniGames.SetActive(false);
        DateScore.Value += 3;
        if (DateScore.Value>= 4)
        {
            WinBox.SetActive(true);
            Debug.Log("You Win!, Well Done!");
            DateScore.TobiasDateOneCompleted = true;
            DateScore.TobiasDateOneSuccess = true;
        } 
        else if (DateScore.Value== 4)
        {
            WinBox.SetActive(true);
            Debug.Log("You Win!");
            DateScore.TobiasDateOneCompleted = true;
            DateScore.TobiasDateOneSuccess = true;
        } 
        else if (DateScore.Value <= 4)
        {
            LoseBox.SetActive(true);
            Debug.Log("You Lose!");
            DateScore.TobiasDateOneCompleted = true;
        }
        
    }
    
    public void MiniGameLost()
    {
        EndOFDateBox.SetActive(true);
        TIMER.SetActive(false);
        MiniGames.SetActive(false);
        if ( DateScore.Value >= 4)
        {
            WinBox.SetActive(true);
            Debug.Log(" You Win!, Well Done!");
            DateScore.TobiasDateOneCompleted = true;
            DateScore.TobiasDateOneSuccess = true;
        } 
        else if (DateScore.Value == 4)
        {
            WinBox.SetActive(true);
            Debug.Log(" You Win");
            DateScore.TobiasDateOneCompleted = true;
            DateScore.TobiasDateOneSuccess = true;
        } 
        else if (DateScore.Value <= 4)
        {
           LoseBox.SetActive(true);
            Debug.Log("You Lose!");
            DateScore.TobiasDateOneCompleted = true;
        }
        
    }

    public void MiniGameOneWin()
    {
        miniGameOne.SetActive(false);
        miniGameTwo.SetActive(true);
        GamePrompter.text = "Use The Mouse to Help Clean Up The Table!";
    }

    public void MiniGameTwoWin()
    {
        miniGameTwo.SetActive(false);
        miniGameThree.SetActive(true);
        GamePrompter.text = "Use the arrow keys to Catch 8 Papers!";
    }

    public void MiniGameThreeWin()
    {
        miniGameThree.SetActive(false);
        gamesCompleted = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NewMiniGameCommunicator.TypingScore == 3)
        {
            MiniGameOneWin();
            Debug.Log(NewMiniGameCommunicator.TypingScore);
        }

        if (NewMiniGameCommunicator.CurrentSlotPoints == 9)
        {
            MiniGameTwoWin();
            Debug.Log("MiniGame has switched");
        }

        if (NewMiniGameCommunicator.PapersCaught == 8)
        {
            MiniGameThreeWin();
            Debug.Log("MiniGame has ended");
        }

        if (gamesCompleted == true && NewMiniGameCommunicator.TimeHasEnded == false)
        {
            MiniGameWon();
            Debug.Log("MiniGame won");
        }

        if (NewMiniGameCommunicator.TimeHasEnded == true)
        {
            MiniGameLost();
            Debug.Log("MiniGame lost");
        }
        
    }
}
