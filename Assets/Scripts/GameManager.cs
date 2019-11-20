using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void NextScene()
    {
        Scene activeScene = SceneManager.GetActiveScene();// Get current scene
        SceneManager.LoadScene(activeScene.buildIndex + 1);// Load next scene
    }

    public void ResetScene()
    {
        Scene activeScene = SceneManager.GetActiveScene();// Get current scene
        SceneManager.LoadScene(activeScene.buildIndex);// reset scene
    }
}