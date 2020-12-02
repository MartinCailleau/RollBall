using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;

    public float distance;

    public float height;

    private Vector3 camPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Position 
        camPosition = target.transform.position;
        camPosition += (-Vector3.forward) * distance;
        camPosition += Vector3.up * height;
        transform.position = camPosition;
        
        // Rotate
        transform.LookAt(target.transform);

    }
}
