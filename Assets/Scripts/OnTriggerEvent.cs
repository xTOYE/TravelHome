using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
    public UnityEvent onEnter;
    public string hitTag = "Player";
    // Clean up code: CTRL + K, CTRL + D
    // Fold Code: CTRL + M + O
    // Un-Fold Code: CTRL + M + P
    private void OnTriggerEnter(Collider other)
    {
        // If the collider's tag is the same as 'hitTag'
        if (other.tag == hitTag)
        {
            // Invoke the event (Run all events in 'onEnter')
            onEnter.Invoke();
        }
    }
}
