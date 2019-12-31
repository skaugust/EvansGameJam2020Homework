using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Target;

    public float TrackingSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Target != null)
        {
            Vector2 delta2 = Target.transform.position - this.transform.position;

            // Make sure we never modify the camera's z.
            Vector3 delta3 = new Vector3(delta2.x, delta2.y, 0);

            transform.position += delta3 * Time.deltaTime * TrackingSpeed;
        }
    }
}
