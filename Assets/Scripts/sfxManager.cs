using UnityEngine;

public class sfxManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void SoundOnCLick()
    {
        audioSource.Play();
    }

    public void SoundOnCLickBack()
    {
        audioSource2.Play();
    }
}
