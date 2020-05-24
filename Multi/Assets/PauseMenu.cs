using System.Collections;
using System.Collections.Generic;
using Com.MoonDevs.MoonWalkers;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public static bool GameSettings = false;
    public static bool backToMenu = false;

    public GameObject pauseMenuUI, settingsMenuUI, TimerUI, WaitingPlayersUI, DecountUI;

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
        if (PlayerWaiting.WaitingPlayersDis)
            WaitingPlayersUI.SetActive(true);
        else if (WaitingTimeChrono.DecountDis)
            DecountUI.SetActive(true);
        else if (WaitingTimeChrono.TimerDis)
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
        WaitingPlayersUI.SetActive(false);
        DecountUI.SetActive(false);
        Time.timeScale = 1f; // Changer la valeur pour le solo
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
