using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace PlayerDependencies
{
public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private float jumpVel = 5f;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float fallVel = -2.5f;

    private float vel;
    public bool jumpPressed;
    public Vector2 movement;
    void Update()
    {
        
        if (jumpPressed == true)
        {
            vel = jumpVel;
        }
        else
        {
            vel = fallVel;
        }

    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(moveSpeed * movement.x, vel);
    }

}

}
