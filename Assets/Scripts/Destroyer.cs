using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public float lifetime = 10f;

    void Update()
    {
        if (lifetime > 10)
        {
            lifetime -= Time.deltaTime;
            if (lifetime <= 0)
            {
                OnDestroy();
            }
        }

        if(this.transform.position.y <= 20)
        {
            OnDestroy();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "destroyer")
        {
            OnDestroy();
        }
    }
    private void OnDestroy()
    {
        Destroy(this.gameObject);
    }
}
