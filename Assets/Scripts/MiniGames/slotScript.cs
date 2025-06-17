using UnityEngine;
using UnityEngine.EventSystems;

// code for slots is referenced from:
// Title: Drag and Drop System in Unity - Puzzle Game Example and Inventory 2021
// Author: GameDevel
// Date: 10 April 2021
// Availability: https://youtu.be/pEOetyJ0ULE?si=r3LwHO1lARQyAKHi
public class slotScript : MonoBehaviour, IDropHandler
{
    public int ID;
    [SerializeField] public miniGameManager MiniGameManager;
    public void OnDrop(PointerEventData eventData)
    
    {
        Debug.Log("Item Dropped");
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<dragObjectScript>().ID == ID)
            {
                Debug.Log("Correct!");
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
                MiniGameManager.AddPoints();
            }
            else
            {
                Debug.Log("Incorrect!");
                eventData.pointerDrag.GetComponent<dragObjectScript>().ResetPosition();
            }
            
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Awake()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
