using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Loads the the game and sets the time to normal speed
    public void PlayGame()
    {
        SceneManager.LoadScene("Gold");
        Time.timeScale = 1f;
    }

    //Exits application
    public void QuitGame()
    {
        Application.Quit();
    }

    //Takes to Main menu
    public void ToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //Makes the cursor visible and not locked
    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
