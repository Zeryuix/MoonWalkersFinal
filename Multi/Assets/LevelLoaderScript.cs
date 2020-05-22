using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun.Demo.PunBasics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Launcher = Com.MoonDevs.MoonWalkers.Launcher;

public class LevelLoaderScript : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public Slider slider;
    
    public void Load()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    
    public void LoadG()
    {
        StartCoroutine(LoadGame());
    }

    public void LoadMainMenu()
    {
        StartCoroutine(LoadLevel(0));
    }

    private void Update()
    {
        if (Launcher.hasJoined)
        {
            LoadG();
            Launcher.hasJoined = false;
        }
    }
    
    IEnumerator LoadGame()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
    } 

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
