using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public GameObject Goal;

    void Start() { }

    void Update() { }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Goal)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
