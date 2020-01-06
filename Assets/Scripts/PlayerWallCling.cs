using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallCling : PhysicsObject
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.LogWarning($"Againstwall: {againstWall}");
        Debug.LogWarning($"Grounded: {grounded}");
        if ( againstWall)
        {
            transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 1));
            Debug.LogWarning("Boing");
        }

        var clinging = false;
        if (clinging && Input.GetButtonDown("Jump"))
        {
            // jump 45 degrees away from wall
        }
    }
}
