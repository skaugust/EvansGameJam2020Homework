using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public CheckPointScript CurrentCheckPoint;

    void Start() { }

    void Update()
    {
        if (transform.position.y <= -20)
        {
            Kill();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<GoalTag>() != null)
        {
            LevelInstance.Instance.WinLevel();
        }
        if (other.gameObject.GetComponent<CheckPointScript>() != null)
        {
            CurrentCheckPoint = other.gameObject.GetComponent<CheckPointScript>();
        }
        if (other.gameObject.tag == "KillOnContact")
        {
            Kill();
        }
    }

    public void Kill()
    {
        CurrentCheckPoint.Activate();
    }
}
