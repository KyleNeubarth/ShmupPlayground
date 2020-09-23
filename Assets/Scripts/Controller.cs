using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Camera mainCamera;
    private Rigidbody rb;
    
    [Range(1, 100)]
    public float moveForce = 5;
    public Vector3 camOffset;
    
    
    public float xOff;
    public float yOff;

    private float hAxis;
    private float vAxis;
    
    void Start()
    {
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");

        mainCamera.transform.position = transform.position+camOffset;
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3(hAxis*Time.deltaTime * moveForce,0,vAxis*Time.deltaTime * moveForce));
    }
}
