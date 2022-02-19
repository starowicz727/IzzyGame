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
    public GameObject winOrLoseMenuUI;
    public GameObject hudUI;
    public Text winTimeTxt, winPiggyTxt, announcement;
    void Start()
    {
        gameTimer = 0f;
        Time.timeScale = 1f;
        GameState.GameFinished = false;
        GameState.PiggyNumber = 0;
        GameState.LivesNumber = 3;
    }

    void Update()
    {
        if (!PauseMenu.GameIsPaused)
        {
            gameTimer += Time.deltaTime;
            minutes = (int)(gameTimer / 60f);
            seconds = (int)(gameTimer % 60f);
            timeText.text = String.Format("{0:00}", minutes) + ":" + String.Format("{0:00}", seconds);
        }
        if (GameState.LivesNumber < 1)
        {
            announcement.text = "you lose :(";
            FindObjectOfType<AudioManager>().Play("youLose");
            EndOfGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            announcement.text = "congrats!";
            FindObjectOfType<AudioManager>().Play("youWin");
            EndOfGame();
        }
    }

    private void EndOfGame()
    {
        PauseMenu.GameIsPaused = true;
        GameState.GameFinished = true;
        hudUI.SetActive(false);
        winOrLoseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        winPiggyTxt.text = GameState.PiggyNumber.ToString();
        winTimeTxt.text = String.Format("{0:00}", minutes) + ":" + String.Format("{0:00}", seconds);
        Cursor.visible = true;
    }

    private void CheckRank(float time, int piggies)
    {

    }
}
