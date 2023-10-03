using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixSound : MonoBehaviour
{
    private static FixSound instance;
    void Awake()
    {
        if (instance != null)
        {
            Destroy (gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);    
        }    
    }

    public void Update()
    {
        if(BulletFly.IsWin)
        {
            Destroy(gameObject);
        }
    }
}
