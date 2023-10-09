using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRound : MonoBehaviour
{

    public GameObject Shell1;
    public GameObject Shell2;
    public GameObject Shell3;

    private void OnEnable() 
    {

        
        Shell1.SetActive(false);
        Shell2.SetActive(false);
        Shell3.SetActive(false);

        if(BulletFly.ShellCounter == 1)
        {
            Shell1.SetActive(true);
        }
        if(BulletFly.ShellCounter == 2)
        {
            Shell1.SetActive(true);
            Shell2.SetActive(true);
        }
        if(BulletFly.ShellCounter == 3)
        {
            Shell1.SetActive(true);
            Shell2.SetActive(true);
            Shell3.SetActive(true);
        }
        LvlShellCount();
        BulletFly.ShellCounter = 0;
    }

    private void LvlShellCount()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        int GetShellCount = PlayerPrefs.GetInt($"Lvl {currentScene} Bullets");


        if(BulletFly.ShellCounter > GetShellCount)
        {
            PlayerPrefs.SetInt($"Lvl {currentScene} Bullets", BulletFly.ShellCounter);
        }

        Debug.Log(PlayerPrefs.GetInt($"Lvl {currentScene} Bullets"));
        
    }


    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void NextRound()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene(8);
    }
}
