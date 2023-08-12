using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldLoot : MonoBehaviour
{
    public int Score = 0;
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Gold")
        {
            Score++;
            Destroy(other.gameObject);
        }
    }
}
