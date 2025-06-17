using UnityEngine;
using UnityEngine.SceneManagement;
public class loadScene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadSienaMiniGame()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadMapDaytime()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSiennasBar()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadTobiasCafe()
    {
        SceneManager.LoadScene(4);
    }

    public void LoadTobiasMinigame()
    {
        SceneManager.LoadScene(5);
    }

    public void LoadNightMap()
    {
        SceneManager.LoadScene(6);
    }

    public void LoadOpeningDialogue()
    {
        SceneManager.LoadScene(7);
    }
    
    
    
}
