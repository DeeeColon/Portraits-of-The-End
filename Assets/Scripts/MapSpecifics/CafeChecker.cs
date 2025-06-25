using UnityEngine;
using UnityEngine.UI;

public class CafeChecker : MonoBehaviour
{
    [SerializeField] public DateChecker DateChecker;
    [SerializeField] private ScoreCommunicator DateScore;
    [SerializeField] public Button Cafe;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DateChecker = GameObject.Find("DateChecker").GetComponent<DateChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DateScore.TobiasDateOneCompleted == true)
        {
            Cafe.enabled = false;
        }
        else
        {
            Cafe.enabled = true;
        }
    }
}
