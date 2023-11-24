using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int previousSceneIndex;

    // Call this method to load the previous scene
    public void LoadPreviousScene()
    {
        if (previousSceneIndex >= 0 && previousSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(previousSceneIndex);
        }
        else
        {
            Debug.LogWarning("No previous scene available");
        }
    }

    // Call this method to load a new scene and update the previous scene index
    public void LoadNewScene(string sceneName)
    {
        previousSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneName);
    }
}
