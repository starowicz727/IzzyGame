using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static int PiggyNumber = 0;
    public static int LivesNumber = 3;
    public static bool GameFinished = false;
    ////public static Player BestPlayer1 = new Player();
    //public static Player BestPlayer1 = new Player("player1",2,69);
    ////public static Player BestPlayer2 = new Player();
    //public static Player BestPlayer2 = new Player("player2",0,2);
    //public static Player BestPlayer3 = new Player();
    ////public static Player BestPlayer4 = new Player();
    //public static Player BestPlayer4 = new Player("player4",2,23);
    //public static Player BestPlayer5 = new Player();
    //public static Player BestPlayer6 = new Player();
    //public static Player BestPlayer7 = new Player();
    //public static List<Player> ListOfBestPlayers = new List<Player>{ BestPlayer1, BestPlayer2, BestPlayer3, BestPlayer4, BestPlayer5, BestPlayer6, BestPlayer7 };

    public static List<Player> ListOfBestPlayers = new List<Player> { new Player(), new Player(), new Player(), new Player(), new Player(), new Player(), new Player() };

    public static void SaveMyGameState() //bêdziemy zapisywaæ w gametiming jesli jakis gracz bd miec lepszy wynik i wejdzie do top7
    {
        DataSave.SaveGameState(ListOfBestPlayers);
    }
    public static void LoadMyGameState() // bêdziemy odczytywaæ dane przy Start() w menu 
    {
        List<Player> data = DataSave.LoadGameState();
        ListOfBestPlayers = data;
        ListOfBestPlayers.Sort();
    }
    public static void ClearAllGameState() //czasem moze sie przydac do testow np
    {
        ListOfBestPlayers.Clear();
        ListOfBestPlayers = new List<Player> { new Player(), new Player(), new Player(), new Player(), new Player(), new Player(), new Player() };
        SaveMyGameState();
    }

}
