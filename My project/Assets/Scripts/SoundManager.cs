using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume")) {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else {
            Load();
        }
        
    }
    public void ChangeVolume() {
        AudioListener.volume = volumeSlider.value;
        SaveSoundSetting();
    }

    private void Load() {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");

    }

    private void SaveSoundSetting() {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
