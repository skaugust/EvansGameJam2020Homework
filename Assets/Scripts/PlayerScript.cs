using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    void Start() { }

    void Update() { }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<GoalTag>() != null)
        {
            LevelInstance.Instance.WinLevel();
        }
    }
}
