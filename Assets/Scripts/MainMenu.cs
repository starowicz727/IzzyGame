using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        //GameState.ClearAllGameState();
        GameState.LoadMyGameState();
        Cursor.visible = true;
    }
    public void StartPlaying()
    {
        SceneManager.LoadScene("Level");
    } 
    public void Quit()
    {
        Application.Quit();
    }
}
