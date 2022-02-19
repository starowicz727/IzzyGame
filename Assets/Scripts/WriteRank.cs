using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteRank : MonoBehaviour //skrypt przypisany do RankMenu
{
    public Text player1Name, player1Pig, player1Time;
    public Text player2Name, player2Pig, player2Time;
    public Text player3Name, player3Pig, player3Time;
    public Text player4Name, player4Pig, player4Time;
    public Text player5Name, player5Pig, player5Time;
    public Text player6Name, player6Pig, player6Time;
    public Text player7Name, player7Pig, player7Time;
    void Start()
    {
        player1Name.text = GameState.BestPlayer1.Name; player1Pig.text = GameState.BestPlayer1.PiggiesNumber.ToString(); player1Time.text = GameState.BestPlayer1.Time.ToString();
        player2Name.text = GameState.BestPlayer2.Name; player2Pig.text = GameState.BestPlayer2.PiggiesNumber.ToString(); player2Time.text = GameState.BestPlayer2.Time.ToString();
        player3Name.text = GameState.BestPlayer3.Name; player3Pig.text = GameState.BestPlayer3.PiggiesNumber.ToString(); player3Time.text = GameState.BestPlayer3.Time.ToString();
        player4Name.text = GameState.BestPlayer4.Name; player4Pig.text = GameState.BestPlayer4.PiggiesNumber.ToString(); player4Time.text = GameState.BestPlayer4.Time.ToString();
        player5Name.text = GameState.BestPlayer5.Name; player5Pig.text = GameState.BestPlayer5.PiggiesNumber.ToString(); player5Time.text = GameState.BestPlayer5.Time.ToString();
        player6Name.text = GameState.BestPlayer6.Name; player6Pig.text = GameState.BestPlayer6.PiggiesNumber.ToString(); player6Time.text = GameState.BestPlayer6.Time.ToString();
        player7Name.text = GameState.BestPlayer7.Name; player7Pig.text = GameState.BestPlayer7.PiggiesNumber.ToString(); player7Time.text = GameState.BestPlayer7.Time.ToString();

    }

}
