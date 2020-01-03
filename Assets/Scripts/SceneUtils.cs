using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneUtils
{
    public static void FirstScene()
    {
        SceneManager.LoadScene(0);
    }

    public static void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static void NextScene()
    {
        int nextIndex = (SceneManager.GetActiveScene().buildIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextIndex);
    }

    public static void QuitGame()
    {
        // This only affects real builds.
        Application.Quit();

        // This only affects game when playing inside the Unity editor.
        UnityEditor.EditorApplication.isPlaying = false;
    }
}


