using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider volSlider;

    public void SetVolume (float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("volume", volume);
        Debug.Log("Volume: " + volume.ToString());
    }

    public float GetVolume ()
    {
        if (PlayerPrefs.HasKey("volume"))
        {
            float volume = PlayerPrefs.GetFloat("volume");
            volSlider.value = volume;
            return volume;
        }

        return 1f;
    }
    void Awake()
    {
        this.SetVolume(this.GetVolume());
    }
}
