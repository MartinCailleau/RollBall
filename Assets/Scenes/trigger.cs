using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            GameManager._instance.UpdateScore(1);
            gameObject.SetActive(false);
            Destroy(gameObject,1f);            
        }
    }
}
