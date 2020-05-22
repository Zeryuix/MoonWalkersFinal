using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
   public AudioMixer audioMixerMenu;

   public void SetVolumeMenu(float volume)
   {
      audioMixerMenu.SetFloat("VolumeMenu", volume);
   }

   public void PlayMulti()
   {
      SceneManager.LoadScene("Menu");
   }
   
   public void Playgame()
   {
      SceneManager.LoadScene("MainGame");
      Time.timeScale = 1f;
   }

   public void QuitGame()
   {
      Debug.Log("Quit");
      Application.Quit();
   }
}
