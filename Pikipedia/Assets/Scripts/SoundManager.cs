using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    public void changeVolume() 
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load() // Load the selected volume level
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save() // Save the selected volume level
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
