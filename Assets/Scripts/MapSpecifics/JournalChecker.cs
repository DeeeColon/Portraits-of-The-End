using UnityEngine;

public class JournalChecker : MonoBehaviour
{
    [SerializeField] private ScoreCommunicator DateScore;

    [SerializeField] private GameObject siennaPortrait;
    [SerializeField] private GameObject tobiasPortrait;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (DateScore.SiennaDateOneCompleted && DateScore.SiennaDateOneSuccess)
        {
            siennaPortrait.SetActive(true);
        }
        else
        {
            siennaPortrait.SetActive(false);
        }
        
        if (DateScore.TobiasDateOneCompleted && DateScore.TobiasDateOneSuccess)
        {
            tobiasPortrait.SetActive(true);
        }
        else
        {
            tobiasPortrait.SetActive(false);
        }
    }
}
