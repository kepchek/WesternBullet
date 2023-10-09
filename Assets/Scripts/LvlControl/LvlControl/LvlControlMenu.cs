using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LvlControlMenu : MonoBehaviour
{
    public Button Lvl2B;
    public Button Lvl3B;
    public Button Lvl4B;
    public Button Lvl5B;

    [Header ("Lvl1")]
    public GameObject Shell1;
    public GameObject Shell2;
    public GameObject Shell3;

    [Header ("Lvl2")]
    public GameObject Shell4;
    public GameObject Shell5;
    public GameObject Shell6;
    
    [Header ("Lvl3")]
    public GameObject Shell7;
    public GameObject Shell8;
    public GameObject Shell9;

    [Header ("Lvl4")]
    public GameObject Shell10;
    public GameObject Shell11;
    public GameObject Shell12;

    [Header ("Lvl5")]
    public GameObject Shell13;
    public GameObject Shell14;
    public GameObject Shell15;

    int lvlComplete;
    int bullet1lvl;
    int bullet2lvl;
    int bullet3lvl;
    int bullet4lvl;
    int bullet5lvl;


    void ShowShells(int Lvl, GameObject shell1, GameObject shell2, GameObject shell3)
    {
        switch (Lvl)
        {
            case 1:
                shell1.SetActive(true);
                break;
            case 2:
                shell1.SetActive(true);
                shell2.SetActive(true);
                break;
            case 3:
                shell1.SetActive(true);
                shell2.SetActive(true);
                shell3.SetActive(true);
                break;
        }
    }
    void Start()
    {
        bullet1lvl = PlayerPrefs.GetInt("Lvl 3 Bullets");
        bullet2lvl = PlayerPrefs.GetInt("Lvl 4 Bullets");
        bullet3lvl = PlayerPrefs.GetInt("Lvl 5 Bullets");
        bullet4lvl = PlayerPrefs.GetInt("Lvl 6 Bullets");
        bullet5lvl = PlayerPrefs.GetInt("Lvl 7 Bullets");

        lvlComplete = PlayerPrefs.GetInt("LevelComplete");
        Lvl2B.interactable = false;
        Lvl3B.interactable = false;
        Lvl4B.interactable = false;
        Lvl5B.interactable = false;

        ShowShells(bullet1lvl, Shell1, Shell2, Shell3);
        ShowShells(bullet2lvl, Shell4, Shell5, Shell6);
        ShowShells(bullet3lvl, Shell7, Shell8, Shell9);
        ShowShells(bullet4lvl, Shell10, Shell11, Shell12);
        ShowShells(bullet5lvl, Shell13, Shell14, Shell15);



        switch (lvlComplete)
        {
            case 3:
                Lvl2B.interactable = true;
                break;
            case 4:
                Lvl2B.interactable = true;
                Lvl3B.interactable = true;
                break;
            case 5:
                Lvl2B.interactable = true;
                Lvl3B.interactable = true;
                Lvl4B.interactable = true;
                break;
            case 6:
                Lvl2B.interactable = true;
                Lvl3B.interactable = true;
                Lvl4B.interactable = true;
                Lvl5B.interactable = true;
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


}