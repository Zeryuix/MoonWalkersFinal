using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuSolo : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool GameSettings = false;
    public static bool backToMenu = false;

    public GameObject pauseMenuUI, settingsMenuUI, TimerUI, DecountUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !GameIsPaused)
        {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && GameIsPaused)
        {
            Resume();
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        GameSettings = false;
        if (WaitingTimeSolo.DecountDis)
            DecountUI.SetActive(true);
        else if (WaitingTimeSolo.TimerDis)
            TimerUI.SetActive(true);
    }

    public void ResumeButton()
    {
        GameIsPaused = false;
    }
    
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        TimerUI.SetActive(false);
        DecountUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        GameSettings = false;
    }

    public void Settings()
    {
        settingsMenuUI.SetActive(true);
        GameSettings = true;
    }
    
    public void BackSettings()
    {
        GameSettings = false;
    }
    
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
        backToMenu = true;
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
