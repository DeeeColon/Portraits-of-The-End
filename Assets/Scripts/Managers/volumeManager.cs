using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


// code for volume Manager is referenced from:
// Title: Unity AUDIO Volume Settings Menu Tutorial
// Author: Rehope Games
// Date: 7 March 2023
// Availability: https://youtu.be/G-JUp8AMEx0?si=C8iXGhLn8XRnz9K0

public class volumeManager : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider musicSlider;
    [SerializeField] Slider sfxSlider;

    public void SetMusicVolume()
    {
         float musicVolume = musicSlider.value;
         audioMixer.SetFloat("music", Mathf.Log10(musicVolume)*20);
         PlayerPrefs.SetFloat("music", musicVolume);
    }

    public void SetSfxVolume()
    {
        float sfxVolume = sfxSlider.value;
        audioMixer.SetFloat("SFX", Mathf.Log10(sfxVolume)*20);
        PlayerPrefs.SetFloat("SFX", sfxVolume);
    }

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("music");
        sfxSlider.value = PlayerPrefs.GetFloat("SFX");
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("music"))
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume();
        }

        if (PlayerPrefs.HasKey("SFX"))
        {
            LoadVolume();
        }
        else
        {
            SetSfxVolume();  
        }
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
