using UnityEngine;

public class clothScrub : MonoBehaviour
{
     
    [SerializeField] int sensitivity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse Y") > 0)
        {
            transform.Translate(Vector3.up * (Time.deltaTime * sensitivity));
            miniGameManager.instance.ScrubbingPoints();
        }

        if (Input.GetAxis("Mouse Y") < 0)
        {
            transform.Translate(Vector3.down * (Time.deltaTime * sensitivity));
            miniGameManager.instance.ScrubbingPoints();
        }

        
    }

}
