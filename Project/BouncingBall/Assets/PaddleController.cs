using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public Transform Transform;

    public float Speed;

    private float _horizontal;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Transform.position = new Vector3(Transform.position.x + _horizontal * Speed * Time.deltaTime, Transform.position.y, Transform.position.z);
    }
}
