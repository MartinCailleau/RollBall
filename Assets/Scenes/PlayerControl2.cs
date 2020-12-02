using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl2 : MonoBehaviour
{
    private Rigidbody r;
    private Vector3 move;
    public float jumpForce;
    public float speed;
    
    void Start()
    {
        r = GetComponent<Rigidbody>();
        r.AddForce(Vector3.up*jumpForce);
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal");
        move.z = Input.GetAxis("Vertical");
        move *= speed;
        r.AddForce(move);
        
    }
    
    
}
