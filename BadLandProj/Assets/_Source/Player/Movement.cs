using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private float jumpVel = 5f;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float fallVel = -2.5f;

    private float vel;
    Vector2 movement;
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetKey(KeyCode.Space))
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
        rb.velocity = new Vector2(moveSpeed * movement.x,vel);
    }
    
}
