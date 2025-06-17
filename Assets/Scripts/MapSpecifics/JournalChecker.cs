using UnityEngine;

public class JournalChecker : MonoBehaviour
{
    [SerializeField] public DateChecker DateChecker;

    [SerializeField] private GameObject siennaPortrait;
    [SerializeField] private GameObject tobiasPortrait;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DateChecker = GameObject.Find("DateChecker").GetComponent<DateChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DateChecker.SiennaDateOneCompleted && DateChecker.SiennaDateOneSuccess)
        {
            siennaPortrait.SetActive(true);
        }
        
        if (DateChecker.TobiasDateOneCompleted && DateChecker.TobiasDateOneSuccess)
        {
            tobiasPortrait.SetActive(true);
        }
    }
}
