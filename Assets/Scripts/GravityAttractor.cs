using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAttractor : MonoBehaviour
{    
    public float gravity = -10f;//negative because refering to force and negative force is a pull

    public void Attract(Rigidbody body)
    {
        Vector3 gravityUp = (body.position - transform.position).normalized;//vector 3 so it can be pulled in every direction
        Vector3 localUp = body.transform.up;

        body.AddForce(gravityUp * gravity);//timesing the movement by the gravity
        body.rotation = Quaternion.FromToRotation(localUp, gravityUp) * body.rotation;
    }
    
}
