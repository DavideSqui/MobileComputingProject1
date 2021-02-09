using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    //controllo volume
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume",volume);
    }
    //controllo qualità
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
    // Start is called before the first frame update
}
