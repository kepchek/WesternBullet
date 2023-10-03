using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool PauseGame;

    public GameObject pauseGameMenu;
    public GameObject PauseTriggerUI;
    public GameObject JoystickUI;


    public void RobertPolson() 
    {
        Pause();
    }

    public void Resume()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
        BulletFly.speed = StartGame.ShellSpeed;
        BulletFly.BulletSound.Play();
        PauseTriggerUI.SetActive(true);
        JoystickUI.SetActive(true);
    }

    public void Pause()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
        BulletFly.speed = 0;
        BulletFly.BulletSound.Stop();
        PauseTriggerUI.SetActive(false);
        JoystickUI.SetActive(false);
    }

    public void LoadMenu()
    {
        BulletFly.IsWin = true;//Off main song
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }

    public void Exit()
    {
        Debug.Log("Конец");
        Application.Quit();
    }
}
