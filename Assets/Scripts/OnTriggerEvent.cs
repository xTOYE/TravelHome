using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
    public UnityEvent onEnter;
    public string hitTag = "Player";
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == hitTag)// If the collider's tag is the same as 'hitTag'
        {
            onEnter.Invoke();// Invoke the event (Run all events in 'onEnter')
        }
    }
}
