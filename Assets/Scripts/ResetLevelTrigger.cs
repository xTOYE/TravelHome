using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetLevelTrigger : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        gameManager.NextScene();
    }
}
