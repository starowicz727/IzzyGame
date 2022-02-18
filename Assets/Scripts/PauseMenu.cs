using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; //moze sie przydac do mierzenia czasu moze tutaj bedziemy mierzyc czas? 
    public GameObject pauseMenuUI;
    public GameObject hudUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !GameState.GameFinished)
        {
            if (GameIsPaused) //kiedy klikamy esc ¿eby wyjœæ z pause menu
            {
                Resume();
            }
            else // kiedy klikamy esc ¿eby wyjœæ z gry
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        hudUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.visible = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        hudUI.SetActive(false); //gdy tego nie zrobie, panel w hud blokuje dostêp do buttonow 
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.visible = true;
    } 
    public void LoadMenu()
    {
        //Time.timeScale = 0f;
        Resume();
        SceneManager.LoadScene("MainMenu"); //mo¿e lepiej nazwy sceny nie zapisywaæ dos³ownie tylko zmienn¹?
    }
    public void NewGame()
    {
        Resume();
        SceneManager.LoadScene("Level"); 
    }
}
