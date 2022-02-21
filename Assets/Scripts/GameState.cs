using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public static int PiggyNumber = 0;
    public static int LivesNumber = 3;
    public static bool GameFinished = false;
    public static float MusicVolume = 0.5f;
    public static float SoundVolume = 1f;


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
