using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointScript : MonoBehaviour
{
    public int DefaultTime = 10;

    [System.NonSerialized]
    public TimerScript Timer;

    [System.NonSerialized]
    public PlayerScript Player;

    [System.NonSerialized]
    public CameraScript Camera;

    private Rigidbody2D rb;

    void Awake()
    {
        Timer = GameObject.FindObjectOfType<TimerScript>();
        Player = GameObject.FindObjectOfType<PlayerScript>();
        rb = Player.GetComponent<Rigidbody2D>();
        Camera = GameObject.FindObjectOfType<CameraScript>();
    }

    public void Activate()
    {
        Timer.ResetTime(DefaultTime);
        Player.transform.position = this.transform.position;
        rb.velocity = new Vector2(0,0);
        Camera.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -10);
    }

    public void Triggered()
    {
       // TODO: Make it change color or something when tagged
    }

}

