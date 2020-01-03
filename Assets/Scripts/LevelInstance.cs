using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInstance : MonoBehaviour
{
    public static LevelInstance Instance;

    [System.NonSerialized]
    public PlayerScript Player;

    public float TotalTimeSeconds = 20;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Player = GameObject.FindObjectOfType<PlayerScript>();
    }

    public void WinLevel()
    {
        SceneUtils.NextScene();
    }

    public void LoseLevel()
    {
        SceneUtils.RestartScene();
    }
}
