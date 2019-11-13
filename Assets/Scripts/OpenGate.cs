using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    public Animation openGate;

    void Start()
    {
        
    }

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E))
            openGate.Play();
    }
}
