using UnityEngine;
using UnityEngine.UI;

public class keyPress : MonoBehaviour
{
    [SerializeField] string KeyValue;
    [SerializeField] Transform ObjectPosition;

    [SerializeField] private float movement;
    [SerializeField] private float movementSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        
    }

    public Transform OriginalPosition { get; set; }

    // Update is called once per frame
    void Update()
    {
        KeyMove();

        if (Input.GetKeyUp(KeyCode.A))
        {
            Debug.Log("Key Was Released");
            return;
        }
    }

    public void KeyMove()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            string keysPressed = Input.inputString;
            if (keysPressed.Length == 1 && keysPressed == KeyValue)
            {
                gameObject.GetComponent<Image>().color = Color.gray;
                LeanTween.moveLocalY(gameObject, 0.5f, movementSpeed);
                Debug.Log("key pressed: " + keysPressed);
            }
            
        }

      
    }
}
