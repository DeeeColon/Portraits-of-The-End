using UnityEngine;

// code for CursorChanger is referenced from:
// Title: How to create a custom cursor in Unity 
// Author: Christina Creates Games
// Date: 18 Jul 2023 
// Availability: https://youtu.be/5bSyIuMEjXE?si=-y6F054SKEVDinQX

public class PointerManager : MonoBehaviour
{
    public static PointerManager instance { get; private set; }
    
    [SerializeField] private Texture2D cursorTextureDefault;
    [SerializeField] private Texture2D cursorTextureHover;
    
    [SerializeField] private Vector2 clickPosition = Vector2.zero;
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.SetCursor(cursorTextureDefault, clickPosition, CursorMode.Auto);
    }

    public void SetToMode(ModeOfCursor modeOfCursor)
    {
        switch (modeOfCursor)
        {
            case ModeOfCursor.Default:
                Cursor.SetCursor(cursorTextureDefault, clickPosition, CursorMode.Auto);
                break;
            case ModeOfCursor.Hover:
                Cursor.SetCursor(cursorTextureHover, clickPosition, CursorMode.Auto);
                break;
        }
    }

    public enum ModeOfCursor
    {
        Default,
        Hover,
    }

   
}
