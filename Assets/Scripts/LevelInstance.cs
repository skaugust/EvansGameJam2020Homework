using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LevelInstance : MonoBehaviour
{
    public static LevelInstance Instance;

    [System.NonSerialized]
    public PlayerScript Player;

    [System.NonSerialized]
    public CameraScript Camera;

    [System.NonSerialized]
    public List<CheckPointScript> AllCheckPoints = new List<CheckPointScript>();

    private CheckPointScript CurrentCheckPoint;

    void Awake()
    {
        Instance = this;
        Player = GameObject.FindObjectOfType<PlayerScript>();
        Camera = GameObject.FindObjectOfType<CameraScript>();
        AllCheckPoints.AddRange(GameObject.FindObjectsOfType<CheckPointScript>());
        CurrentCheckPoint = AllCheckPoints.First(cp => cp.IsSpawn);
    }

    void Start()
    {
        CurrentCheckPoint.Activate();
    }

    public void WinLevel()
    {
        SceneUtils.NextScene();
    }

    public void LoseLevel()
    {
        CurrentCheckPoint.Activate();
    }

    public void SetCurrentCheckPoint(CheckPointScript checkPoint)
    {
        CurrentCheckPoint.SetTriggered(false);
        CurrentCheckPoint = checkPoint;
        CurrentCheckPoint.SetTriggered(true);
    }
}
