using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Component gatecolliderhere;
    public GameObject keygone;

    void OnTriggerStay ()
    {
        if(Input.GetKey(KeyCode.E))
        gatecolliderhere.GetComponent<BoxCollider>().enabled = true;//so is active at start of scene

        if (Input.GetKey(KeyCode.E))
        keygone.SetActive(false);//pressing 'E' deletes the gate from the scene
    }
}
