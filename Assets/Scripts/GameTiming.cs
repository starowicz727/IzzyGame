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
    public InputField nameField;
    public Button playAgainBtn, mainMenuBtn;
    bool saveCurrentPlayer = false;

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
            GameState.LivesNumber = 3;
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") //gry gracz dobiegnie do mety
        {
            announcement.text = "congrats!";
            FindObjectOfType<AudioManager>().Play("youWin");

            CheckRank(gameTimer, GameState.PiggyNumber); //sprawdzamy czy zdobyte punkty s¹ lepsze niz obecnie w TOP7
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
        if(GameState.ListOfBestPlayers[6].CompareTo(new Player("", piggies, time))<0) //jesli gracz7 z listy jest lepszy niz obecny gracz to nie wpisujemy w liste
        {
            nameField.gameObject.SetActive(false);
            playAgainBtn.gameObject.SetActive(true);
            mainMenuBtn.gameObject.SetActive(true);
        }
        else
        {
            saveCurrentPlayer = true;
            nameField.gameObject.SetActive(true);
            playAgainBtn.gameObject.SetActive(false);
            mainMenuBtn.gameObject.SetActive(false);
        }
    }

    public void SetName(String newName)
    {
        if (newName.Length > 0)
        {
            playAgainBtn.gameObject.SetActive(true);
            mainMenuBtn.gameObject.SetActive(true);
        }
        else
        {
            playAgainBtn.gameObject.SetActive(false);
            mainMenuBtn.gameObject.SetActive(false);
        }
    }
    public void ClickToSaveRank()
    {
        if (saveCurrentPlayer)
        {
            Player playerToSave = new Player(nameField.text, GameState.PiggyNumber, gameTimer);
            GameState.ListOfBestPlayers.Add(playerToSave);
            GameState.ListOfBestPlayers.Sort();
            GameState.ListOfBestPlayers.Remove(GameState.ListOfBestPlayers[7]);
            GameState.SaveMyGameState();
        }
        //else
        //{

        //}
    }
}
