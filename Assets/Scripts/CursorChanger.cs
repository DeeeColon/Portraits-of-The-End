using UnityEngine;
using UnityEngine.EventSystems;

// code for CursorChanger is referenced from:
// Title: How to create a custom cursor in Unity 
// Author: Christina Creates Games
// Date: 18 Jul 2023 
// Availability: https://youtu.be/5bSyIuMEjXE?si=-y6F054SKEVDinQX
public class CursorChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private PointerManager.ModeOfCursor modeOfCursor;
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        PointerManager.instance.SetToMode(modeOfCursor);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        PointerManager.instance.SetToMode(PointerManager.ModeOfCursor.Default);
    }
}
