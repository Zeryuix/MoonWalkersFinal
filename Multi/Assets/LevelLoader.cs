using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public Slider Slider;
    public static float speedSlide = 0.02f;

    public void Update()
    {
        Slider.value += speedSlide;
    }
}
