using UnityEngine;
using TMPro;

public class playerInformer : MonoBehaviour
{
    [SerializeField] private ScoreCommunicator DateScore;

    [SerializeField] private TextMeshProUGUI prompter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        prompter.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (DateScore.SiennaDateOneCompleted && DateScore.TobiasDateOneCompleted)
        {
            prompter.text = "Congratulations! You have reached the end of the game, thank you for playing.";
        }

        else if (DateScore.SiennaDateOneCompleted)
        {
            prompter.text = "Select The Cafe to find the next person to interview.";
        }

        else if (DateScore.TobiasDateOneCompleted)
        {
            prompter.text = "Select Sienna's Bar to find the next person to interview.";
        }
        
        else if (DateScore.TobiasDateOneCompleted && DateScore.TobiasDateOneSuccess)
        {
            prompter.text = "Select Sienna's Bar to find the next person to interview. Check out your photo in your journal";
        }
        
        else if (DateScore.SiennaDateOneCompleted && DateScore.SiennaDateOneSuccess)
        {
            prompter.text = "Select The Cafe to find the next person to interview. Check out your photo in your journal";
        }
        
    }
}
