using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    void Start()
    {
        
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
