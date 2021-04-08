using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] Rigidbody2D rbPlayer;
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 1f, jumpForce = 1f, checkGroundRadius;
    [SerializeField] private Transform groundPoint;
    [SerializeField] private LayerMask groundLayer;
    private bool isGrounded = false;

    private void Update()
    {
        Move();
        Jump();
        CheckIfGrounded();

    }

    private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rbPlayer.velocity = new Vector2(moveBy, rbPlayer.velocity.y);

        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1f;
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1f;
        }
        transform.localScale = characterScale;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, jumpForce);
        }
        CheckIfGrounded();
    }

    private void CheckIfGrounded()
    {
        Collider2D colliders = Physics2D.OverlapCircle(groundPoint.position, checkGroundRadius, groundLayer);

        if (colliders != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
