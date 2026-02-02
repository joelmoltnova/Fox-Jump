using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJump : MonoBehaviour
{
    public float jumpForce = 5f;
    public float jumpInterval = 2f;

    private Rigidbody2D rb;
    private float jumpTimer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpTimer = jumpInterval;
    }

    void Update()
    {
        jumpTimer -= Time.deltaTime;

        if (jumpTimer <= 0f)
        {
            Jump();
            jumpTimer = jumpInterval;
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0f);
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}