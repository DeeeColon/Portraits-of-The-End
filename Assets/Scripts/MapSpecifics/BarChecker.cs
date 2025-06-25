using UnityEngine;
using UnityEngine.UI;

public class BarChecker : MonoBehaviour
{
    [SerializeField] public DateChecker DateChecker;
    [SerializeField] private ScoreCommunicator DateScore;

    [SerializeField] public Button SiennasBar;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DateChecker = GameObject.Find("DateChecker").GetComponent<DateChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DateScore.SiennaDateOneCompleted == true)
        {
            SiennasBar.enabled = false;
        }
        else
        {
            SiennasBar.enabled = true;
        }
    }
}
