using Unity.VisualScripting;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class mover : MonoBehaviour
{
    [SerializeField] int sensetivity = 5;
    [SerializeField] private MiniGameCommunicator NewMiniGameCommunicator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-transform.right * Time.deltaTime * sensetivity);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(transform.right * Time.deltaTime * sensetivity);
        }

        if (NewMiniGameCommunicator.PapersCaught >= 2)
        {
            print(NewMiniGameCommunicator.PapersCaught);
        }
        
        
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "paper")
        {
            NewMiniGameCommunicator.PapersCaught ++;
        }

        if (collision.gameObject.tag == "paper")
        {
            print("collided with paper");
        }
    } 
}
