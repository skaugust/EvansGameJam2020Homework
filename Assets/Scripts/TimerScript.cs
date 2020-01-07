using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    private TextMeshProUGUI label;
    private int previousSeconds;
    private float startTicks;
    private int availableTime;

    void Start()
    {
        label = GetComponent<TextMeshProUGUI>();
    }

    public void ResetTime(int AllowedTime)
    {
        availableTime = AllowedTime;
        startTicks = Time.time;
    }

    void Update()
    {
        int newSeconds = (int)Mathf.Floor(availableTime - (Time.time - startTicks));
        if (newSeconds != previousSeconds)
        {
            previousSeconds = newSeconds;
            // D means decimal, 3 means we always get 3 characters, sometimes with leading 0s.
            label.text = "Timer: " + newSeconds.ToString("D3");
        }
        if (newSeconds <= 0)
        {
            LevelInstance.Instance.LoseLevel();
        }
    }
}
