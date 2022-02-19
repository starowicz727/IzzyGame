using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static int PiggyNumber = 0;
    public static int LivesNumber = 3;
    public static bool GameFinished = false;
    public static Player BestPlayer1 = new Player();
    public static Player BestPlayer2 = new Player();
    public static Player BestPlayer3 = new Player();
    public static Player BestPlayer4 = new Player();
    public static Player BestPlayer5 = new Player();
    public static Player BestPlayer6 = new Player();
    public static Player BestPlayer7 = new Player();


    public static void SaveMyGameState() //bêdziemy zapisywaæ w gametiming jesli jakis gracz bd miec lepszy wynik i wejdzie do top7
    {
        DataSave.SaveGameState(BestPlayer1,BestPlayer2,BestPlayer3,BestPlayer4,BestPlayer5,BestPlayer6,BestPlayer7);
    }
    public static void LoadMyGameState() // bêdziemy odczytywaæ dane przy Start() w menu oraz Start() przy BackgroundMusic.cs   
    {                                                                                       //bo ten skrypt jest na ka¿dej scenie
        PlayerData data = DataSave.LoadGameState();
        BestPlayer1 = data.Player1;
        BestPlayer2 = data.Player2;
        BestPlayer3 = data.Player3;
        BestPlayer4 = data.Player4;
        BestPlayer5 = data.Player5;
        BestPlayer6 = data.Player6;
        BestPlayer7 = data.Player7;
    }


}
