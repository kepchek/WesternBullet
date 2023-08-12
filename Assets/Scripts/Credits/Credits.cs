using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void CreditsNext()
    {
        Time.timeScale = 1f;
       SceneManager.LoadScene(6); 
    }

}
