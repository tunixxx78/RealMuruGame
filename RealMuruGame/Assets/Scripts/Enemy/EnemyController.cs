using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rbEnemy;
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 1f, jumpForce = 1f, checkGroundRadius;
    [SerializeField] private Transform groundPoint;
    [SerializeField] private LayerMask groundLayer;
    private bool isGrounded = false;

    private void Update()
    {
        //Move();
        //Jump();
        CheckIfGrounded();

    }

    /*private void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rbEnemy.velocity = new Vector2(moveBy, rbEnemy.velocity.y);

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
    }*/

    private void Jump()
    {
        if (isGrounded)
        {
            rbEnemy.velocity = new Vector2(rbEnemy.velocity.x, jumpForce);
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
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Jump();
        }
    }
}
