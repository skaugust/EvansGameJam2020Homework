using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInstance : MonoBehaviour
{
    public static LevelInstance Instance;

    [System.NonSerialized]
    public PlayerScript Player;

    [System.NonSerialized]
    public CameraScript Camera;

    public float TotalTimeSeconds = 20;

    void Awake()
    {
        Instance = this;
        Player = GameObject.FindObjectOfType<PlayerScript>();
        Camera = GameObject.FindObjectOfType<CameraScript>();
    }

    void Start() { }

    public void WinLevel()
    {
        SceneUtils.NextScene();
    }

    public void LoseLevel()
    {
        SceneUtils.RestartScene();
    }
}
