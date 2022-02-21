using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustSliders : MonoBehaviour
{
    public Slider musicSlider, soundSlider;
    void Start()
    {
        musicSlider.value = GameState.MusicVolume;
        soundSlider.value = GameState.SoundVolume;
    }

    // Update is called once per frame
    void Update()
    {
        GameState.MusicVolume = musicSlider.value;
        GameState.SoundVolume = soundSlider.value;
    }
}
