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

    public void LoadMiniGame()
    {
        SceneManager.LoadScene(3);
    }
}
