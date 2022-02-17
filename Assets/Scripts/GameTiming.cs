using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTiming : MonoBehaviour //skrypt przypisany do flagi, sprawdza czy dotarliœmy do mety 
{
    public Text timeText;
    private float gameTimer;
    private float minutes, seconds;
    public GameObject winMenuUI;
    public GameObject hudUI;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PauseMenu.GameIsPaused = true;
            GameState.GameFinished = true;
            hudUI.SetActive(false);
            winMenuUI.SetActive(true);
            Time.timeScale = 0f;
            Cursor.visible = true;
            Debug.Log("you win");
        }
    }
}
