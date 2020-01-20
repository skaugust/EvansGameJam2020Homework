// https://learn.unity.com/tutorial/live-session-2d-platformer-character-controller

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject
{

    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;

    protected bool grabbing = false;

    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        bool shouldStartGrabbing = againstWall && !grabbing && Input.GetKeyDown(KeyCode.LeftShift);
        bool grabIsReleased = grabbing && Input.GetKeyUp(KeyCode.LeftShift);

        if (grabIsReleased)
        {
            grabbing = false;
        }
        if (shouldStartGrabbing)
        {
            grabbing = true;
        }

        if (Input.GetButtonDown("Jump") && (grounded || grabbing))
        {
            velocity.y = jumpTakeOffSpeed;
            grabbing = false;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            {
                velocity.y = velocity.y * 0.5f;
            }
        }
        else if (grabbing)
        {
            velocity.y = 0;
        }

        if (grabbing)
        {
            move.x = 0;
        }
        else
        {
            move.x = Input.GetAxis("Horizontal");
        }

        bool flipSprite = (spriteRenderer.flipX ? (move.x > 0.01f) : (move.x < 0.01f));
        if (flipSprite)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }

        targetVelocity = move * maxSpeed;
    }
}
