using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateWithCamera : MonoBehaviour
{
    // 0 means don't change it. 1 means maintain fixed offset. -1 means go the opposite way.
    public Vector3 cameraScale = new Vector3(1, 1, 1);

    private Vector3 initialOffset;

    void Start()
    {
        initialOffset = gameObject.transform.position - Vector3.Scale(LevelInstance.Instance.Camera.transform.position, cameraScale);
    }

    void LateUpdate()
    {
        gameObject.transform.position = Vector3.Scale(LevelInstance.Instance.Camera.transform.position, cameraScale) + initialOffset;
    }
}
