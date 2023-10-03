using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform LeadObj;
    public float followSharpness = 0.1f; 
    Vector3 followDist; 

    void Start()
    {
        //Get initial scene distance to lead object
        followDist = transform.position - LeadObj.position;    
    }

    void LateUpdate()
    {
        Vector3 targetPos = LeadObj.position + followDist;

        //targetPos.z = transform.position.z;

        transform.position += (targetPos - transform.position) * followSharpness;
    }

}
