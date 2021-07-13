using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rbEnemy;
    [SerializeField] private GameObject player, normalSpawner, rageSpawner;
    [SerializeField] private float jumpForce = 2.5f, checkGroundRadius;
    [SerializeField] private Transform groundPoint;
    [SerializeField] private LayerMask groundLayer;
    private bool isGrounded = false;

    private void Update()
    {
        JumpLower();
        CheckIfGrounded();

    }

    public void JumpLower()
    {
        if (isGrounded)
        {
            rbEnemy.velocity = new Vector2(rbEnemy.velocity.x, jumpForce);
        }
        CheckIfGrounded();
    }

    public void JumpHigh()
    {
        if (isGrounded)
        {
            rbEnemy.velocity = new Vector2(rbEnemy.velocity.x, jumpForce * 2);
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

    public void RageEnemy()
    {
        rageSpawner.SetActive(true);
    }
}
