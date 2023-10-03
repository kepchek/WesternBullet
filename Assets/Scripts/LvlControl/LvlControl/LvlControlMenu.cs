using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LvlControlMenu : MonoBehaviour
{
    public Button Lvl2B;
    public Button Lvl3B;

    int lvlComplete;

    void Start()
    {

        lvlComplete = PlayerPrefs.GetInt("LevelComplete");
        Debug.Log(lvlComplete);
        Lvl2B.interactable = false;
        Lvl3B.interactable = false;

        switch (lvlComplete)
        {
            case 3:
                Lvl2B.interactable = true;
                break;
            case 4:
                Lvl2B.interactable = true;
                Lvl3B.interactable = true;
                break;
        }
    }

    public void LoadTo(int lvl)
    {
        SceneManager.LoadScene(lvl);
    }

    public void Reset()
    {
        Lvl2B.interactable = false;
        Lvl3B.interactable = false;
        PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
