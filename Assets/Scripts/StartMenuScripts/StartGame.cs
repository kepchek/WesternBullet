using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public static float ShellSpeed = 0.06f;
    public static float Sens = 2f;
    public static float Vol = 0.5f;

    public Slider SensSlider;
    public Slider VolumeSlider;


    private void Start() {
        SensSlider.value = Sens;
        VolumeSlider.value = Vol;
        Time.timeScale = 1f;
    }
    public void GameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SetVolume()
    {
        AudioListener.volume = VolumeSlider.value;
        Vol = AudioListener.volume;
    }

    public void SetSensivity()
    {
        Sens = SensSlider.value;
    }
    public void SetMediumMode()
    {
        ShellSpeed = 0.06f;
    }

    public void SetHardMode()
    {
        ShellSpeed = 0.12f;
    }


    public void ExitGame()
    {
        Debug.Log("Конец");
        Application.Quit();
    }

    public void GoToCredits()
    {
       SceneManager.LoadScene(6); 
    }

}
