using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneSkip : MonoBehaviour
{

    public void ButtonDown()
    {
        SceneManager.LoadScene(2);  
    }
}
