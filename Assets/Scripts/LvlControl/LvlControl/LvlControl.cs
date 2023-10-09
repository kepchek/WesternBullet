using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlControl : MonoBehaviour
{
    public static LvlControl instance = null;
    int sceneIndex;
    int lvlComplete;


    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        lvlComplete = PlayerPrefs.GetInt("LevelComplete");
    }

    public void isEndGame()
    {
        if(sceneIndex == 7)
        {
            //SceneManager.LoadScene("StartMenu");
        }
        else
        {
            if(lvlComplete < sceneIndex)
            {
                PlayerPrefs.SetInt("LevelComplete", sceneIndex);
            }
        }
    }
}
