using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData //klasa potrzebna ¿eby jej instancje wrzuciæ w BinaryFormatter
{
    public Player Player1, Player2, Player3, Player4, Player5, Player6, Player7;

    public PlayerData(Player player1, Player player2, Player player3, Player player4, Player player5, Player player6, Player player7)
    {
        Player1 = player1;
        Player2 = player2;
        Player3 = player3;
        Player4 = player4;
        Player5 = player5;
        Player6 = player6;
        Player7 = player7;
    }
}
