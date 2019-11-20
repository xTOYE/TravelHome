using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5f;

    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");//moveing up and down
        float inputV = Input.GetAxis("Vertical");//moveing left and right
        Vector3 direction = new Vector3(inputH, 0, inputV);
        rb.AddForce(direction * speed);//multiplying movement by a public speed

    }
}
