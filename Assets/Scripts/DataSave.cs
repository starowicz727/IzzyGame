using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class DataSave //klasa statyczna ¿eby nie utworzyæ ró¿nych instancji 
{
   public static void SaveGameState(Player player1, Player player2, Player player3, Player player4, Player player5, Player player6, Player player7)
   {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/FindItGameState.txt"; //persistentDataPath to w³aœciwoœæ uniwersalna dla ka¿dego systemu operacyjnego 
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData gameStateData = new PlayerData(player1, player2, player3, player4, player5, player6, player7);

        formatter.Serialize(stream, gameStateData);
        stream.Close();
   }

    public static PlayerData LoadGameState() //odczytujemy plik do obiektu PlayerData
    {
        string path = Application.persistentDataPath + "/FindItGameState.txt"; //persistentDataPath to w³aœciwoœæ uniwersalna dla ka¿dego systemu operacyjnego 
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData gameStateData = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return gameStateData;
        }
        else
        {
            Debug.LogError("File not found in " + path);
            return null;
        }
    }

}
