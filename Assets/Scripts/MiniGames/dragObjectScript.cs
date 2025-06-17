using UnityEngine;
using UnityEngine.EventSystems;
// code for Dragging Script is referenced from:
// Title: Drag and Drop System in Unity - Puzzle Game Example and Inventory 2021
// Author: GameDevel
// Date: 10 April 2021
// Availability: https://youtu.be/pEOetyJ0ULE?si=r3LwHO1lARQyAKHi
public class dragObjectScript : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTrans;
    public Canvas canvas;
    private CanvasGroup canvasGroup;
    public int ID;
    private Vector2 initPos;

    void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        initPos = transform.position;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Click");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        Debug.Log("BeginDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        Debug.Log("EndDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTrans.anchoredPosition += eventData.delta / canvas.scaleFactor;
        Debug.Log("Drag");
    }
    
    public void ResetPosition()
    {
        transform.position = initPos;
        Debug.Log("ResetPosition");
    }
}
