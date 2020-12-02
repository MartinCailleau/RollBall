using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger2 : MonoBehaviour
{

    public float growFactor = 1.1f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {    
            other.transform.localScale *= growFactor;
            Destroy(gameObject);    
        }
    }
}
