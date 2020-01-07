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

    [System.NonSerialized]
    public CheckPointScript Spawn;

    void Awake()
    {
        Instance = this;
        Player = GameObject.FindObjectOfType<PlayerScript>();
        Camera = GameObject.FindObjectOfType<CameraScript>();
    }

    void Start()
    {
        Spawn = GameObject.Find("SpawnPoint").GetComponent<CheckPointScript>();
        Spawn.Activate();
    }

    public void WinLevel()
    {
        SceneUtils.NextScene();
    }

    public void LoseLevel()
    {
        Player.Kill();
    }
}
