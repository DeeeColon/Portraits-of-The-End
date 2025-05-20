using System;
using UnityEngine;

public class lemonChop : MonoBehaviour
{
    public bool moveLeft;
    public bool moveDown;
    public bool moveRight;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveLeft = true;
        moveDown = false;
        moveRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveLeft == true)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * 8));
        }

        if (transform.position.x < -8)
        {
            moveLeft = false;
            moveRight = true;
        }

        if (moveLeft == false && moveRight == true)
        {
            transform.Translate(Vector3.right * (Time.deltaTime * 8));
        }

        if (transform.position.x > 8)
        {
            moveLeft = true;
            moveRight = false;
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            moveDown = true;
            moveLeft = false;
            moveRight = false;
            
        }

        if (moveDown == true)
        {
            transform.Translate(Vector3.down * (Time.deltaTime * 10));
        }
    }

    void OnTriggerEnter2D(Collider2D trigger)

    {

        if (trigger.gameObject.name == "Lemon")
        {
            print("Collied With Lemon");
            miniGameManager.instance.Chop();
            moveDown = false;
            moveLeft = false;
            moveRight = false;
            Destroy(gameObject);

        }
    }
}
