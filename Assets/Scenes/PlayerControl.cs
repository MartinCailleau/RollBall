using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 2;
    public float jumpForce = 10;
    public GameObject spawnPoint;
    private Rigidbody _rigidbody;
    
    private Vector3 move;

    public float massConsomation;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.AddForce(Vector3.forward*1, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
        // Input player
        move.x = Input.GetAxis("Horizontal");
        move.z = Input.GetAxis("Vertical");
      //  move.z += 0.1f;
        move = move * 2;
        
        // jump 
        // check grounded
        move.y = 0;
        if (Physics.Raycast(transform.position,Vector3.down,transform.localScale.magnitude))
        {
            Debug.Log("Hit");
            move.y = (Input.GetButtonDown("Jump"))?jumpForce:0;
        }
        
        // mass consomation
        // transform.localScale *= 1 - ((massConsomation * _rigidbody.velocity.normalized.magnitude)* Time.deltaTime);

        if (transform.localScale.magnitude < 0.1)
        {
            Debug.Log("GameOver");
            // gameover & restart
        }
        _rigidbody.AddForce(move, ForceMode.Force);

    }

    public void respawn()
    {
        _rigidbody.velocity = Vector3.zero;
        transform.position = spawnPoint.transform.position;
    }
}
