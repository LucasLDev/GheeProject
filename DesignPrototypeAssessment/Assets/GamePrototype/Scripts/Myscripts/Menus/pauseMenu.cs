using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public MainMenu _menu;
    public static bool isPaused = false;

    public GameObject pauseUI;

    void Update()
    {
        // if game is paused then unlock mouse and make it visible
        if(isPaused)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        //else lock it and make it invisible 
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        
        //if player presses escape
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            //if game is paused, resume game
            if (isPaused)
            {
                Resume();
            }  
            //pauses game if is not paused
            else
            {
                Pause();
            }
            
        }
    }

    //pause UI turns off, timescale is set to normal speed
    public void Resume()
    {
        pauseUI.SetActive(false);
        Time.timeScale =1f;
        isPaused = false;
    }

    //pause ui turns on, timescale is set to 0 (paused)
    void Pause ()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    //resets timescale to normal speed
    //resumes game
    //Loads main menu scene

    public void Menu()
    {
        Time.timeScale = 1f;
        Resume();
        SceneManager.LoadScene("MainMenu");
    }

    //Exits application
    public void Exit()
    {
        Application.Quit();
    }
}
