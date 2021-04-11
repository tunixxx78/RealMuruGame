using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rbEnemy;
    [SerializeField] private GameObject player, normalSpawner, rageSpawner;
    [SerializeField] private float speed = 1f, jumpForce = 2.5f, checkGroundRadius;
    [SerializeField] private Transform groundPoint;
    [SerializeField] private LayerMask groundLayer;
    private bool isGrounded = false;

    private void Update()
    {
        //Move();
        JumpLower();
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
    /*private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            normalSpawner.SetActive(false);
            rageSpawner.SetActive(true);
            Jump();
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<BarrelSpawner>().StopSpawning();
            normalSpawner.SetActive(false);
            rageSpawner.SetActive(false);
        }
    }*/
}
