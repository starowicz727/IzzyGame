using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class WriteRank : MonoBehaviour //skrypt przypisany do RankMenu
{
    public Text player1Name, player1Pig, player1Time;
    public Text player2Name, player2Pig, player2Time;
    public Text player3Name, player3Pig, player3Time;
    public Text player4Name, player4Pig, player4Time;
    public Text player5Name, player5Pig, player5Time;
    public Text player6Name, player6Pig, player6Time;
    public Text player7Name, player7Pig, player7Time;

    private int minutes, seconds;
    private float gameTimer;
    void Start()
    {
        player1Name.text = GameState.ListOfBestPlayers[0].Name; player1Pig.text = GameState.ListOfBestPlayers[0].PiggiesNumber.ToString();
        gameTimer = GameState.ListOfBestPlayers[0].Time;
        if(gameTimer < 356400) //jesli to jest faktycznie wynik gracza a nie wpisany poczatkowy jakis
        {
            minutes = (int)(gameTimer / 60f);
            seconds = (int)(gameTimer % 60f);
            player1Time.text = String.Format("{0:00}", minutes) + ":" + String.Format("{0:00}", seconds);
        }
        else
        {
            player1Time.text = "xx:xx:xx";
        }
        
        player2Name.text = GameState.ListOfBestPlayers[1].Name; player2Pig.text = GameState.ListOfBestPlayers[1].PiggiesNumber.ToString();
        gameTimer = GameState.ListOfBestPlayers[1].Time;
        if (gameTimer < 356400) //jesli to jest faktycznie wynik gracza a nie wpisany poczatkowy jakis
        {
            minutes = (int)(gameTimer / 60f);
            seconds = (int)(gameTimer % 60f);
            player2Time.text = String.Format("{0:00}", minutes) + ":" + String.Format("{0:00}", seconds);
        }
        else
        {
            player2Time.text = "xx:xx:xx";
        }

        player3Name.text = GameState.ListOfBestPlayers[2].Name; player3Pig.text = GameState.ListOfBestPlayers[2].PiggiesNumber.ToString();
        gameTimer = GameState.ListOfBestPlayers[2].Time;
        if (gameTimer < 356400) //jesli to jest faktycznie wynik gracza a nie wpisany poczatkowy jakis
        {
            minutes = (int)(gameTimer / 60f);
            seconds = (int)(gameTimer % 60f);
            player3Time.text = String.Format("{0:00}", minutes) + ":" + String.Format("{0:00}", seconds);
        }
        else
        {
            player3Time.text = "xx:xx:xx";
        }

        player4Name.text = GameState.ListOfBestPlayers[3].Name; player4Pig.text = GameState.ListOfBestPlayers[3].PiggiesNumber.ToString();
        gameTimer = GameState.ListOfBestPlayers[3].Time;
        if (gameTimer < 356400) //jesli to jest faktycznie wynik gracza a nie wpisany poczatkowy jakis
        {
            minutes = (int)(gameTimer / 60f);
            seconds = (int)(gameTimer % 60f);
            player4Time.text = String.Format("{0:00}", minutes) + ":" + String.Format("{0:00}", seconds);
        }
        else
        {
            player4Time.text = "xx:xx:xx";
        }

        player5Name.text = GameState.ListOfBestPlayers[4].Name; player5Pig.text = GameState.ListOfBestPlayers[4].PiggiesNumber.ToString();
        gameTimer = GameState.ListOfBestPlayers[4].Time;
        if (gameTimer < 356400) //jesli to jest faktycznie wynik gracza a nie wpisany poczatkowy jakis
        {
            minutes = (int)(gameTimer / 60f);
            seconds = (int)(gameTimer % 60f);
            player5Time.text = String.Format("{0:00}", minutes) + ":" + String.Format("{0:00}", seconds);
        }
        else
        {
            player5Time.text = "xx:xx:xx";
        }

        player6Name.text = GameState.ListOfBestPlayers[5].Name; player6Pig.text = GameState.ListOfBestPlayers[5].PiggiesNumber.ToString();
        gameTimer = GameState.ListOfBestPlayers[5].Time;
        if (gameTimer < 356400) //jesli to jest faktycznie wynik gracza a nie wpisany poczatkowy jakis
        {
            minutes = (int)(gameTimer / 60f);
            seconds = (int)(gameTimer % 60f);
            player6Time.text = String.Format("{0:00}", minutes) + ":" + String.Format("{0:00}", seconds);
        }
        else
        {
            player6Time.text = "xx:xx:xx";
        }

        player7Name.text = GameState.ListOfBestPlayers[6].Name; player7Pig.text = GameState.ListOfBestPlayers[6].PiggiesNumber.ToString();
        gameTimer = GameState.ListOfBestPlayers[6].Time;
        if (gameTimer < 356400) //jesli to jest faktycznie wynik gracza a nie wpisany poczatkowy jakis
        {
            minutes = (int)(gameTimer / 60f);
            seconds = (int)(gameTimer % 60f);
            player7Time.text = String.Format("{0:00}", minutes) + ":" + String.Format("{0:00}", seconds);
        }
        else
        {
            player7Time.text = "xx:xx:xx";
        }
    }

}
