using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //<access-specifier>   <data-type>   <variable-name>
    public Rigidbody rb;
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(inputH, 0, inputV);
        rb.AddForce(direction * speed);

    }
}
