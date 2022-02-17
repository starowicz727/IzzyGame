using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTiming : MonoBehaviour
{
    public Text timeText;
    private float gameTimer;
    private float minutes, seconds;
    void Start()
    {
        gameTimer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.GameIsPaused)
        {
            gameTimer += Time.deltaTime;
            minutes = (int)(gameTimer / 60f);
            seconds = (int)(gameTimer % 60f);
            timeText.text = String.Format("{0:00}", minutes) + ":" + String.Format("{0:00}", seconds);
        }
    }
}
