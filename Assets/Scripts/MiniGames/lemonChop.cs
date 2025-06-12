using System;
using UnityEngine;

public class lemonChop : MonoBehaviour
{
    public bool moveLeft;
    public bool moveDown;
    public bool moveRight;
    [SerializeField] int sensitivity;
    public GameObject lemon;
    public GameObject prompt;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OriginalPosition = gameObject.transform.position;
        moveLeft = true;
        moveDown = false;
        moveRight = false;
    }

    public Vector3 OriginalPosition { get; set; }

    // Update is called once per frame
    void Update()
    {
        if (moveLeft == true)
        {
            transform.Translate(Vector3.left * (Time.deltaTime * sensitivity));
        }

        if (transform.position.x < -8)
        {
            moveLeft = false;
            moveRight = true;
        }

        if (moveLeft == false && moveRight == true)
        {
            transform.Translate(Vector3.right * (Time.deltaTime * sensitivity));
        }

        if (transform.position.x > 8)
        {
            moveLeft = true;
            moveRight = false;
        }

        if (transform.position.y < -10)
        {
            gameObject.transform.position = OriginalPosition;
            moveDown = false;
            moveLeft = true;
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
            lemon.SetActive(false);
            prompt.SetActive(false);

        }
    }
}
