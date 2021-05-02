using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] Rigidbody2D rbPlayer;
    [SerializeField] private GameObject player, enemyHealthBar;
    [SerializeField] private float speed = 1f, jumpForce = 1f, checkGroundRadius, lowJumpMultiplier = 2f, fallMultiplier = 2.5f;
    [SerializeField] private Transform groundPoint;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Animator playerAnimator;
    private bool isGrounded = false;

    private void Update()
    {
        Move();
        Jump();
        CheckIfGrounded();
        //BetterJump();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rbPlayer.velocity = new Vector2(moveBy, rbPlayer.velocity.y);

        playerAnimator.SetBool("Run", x != 0f);

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
    public void DirectionOfCharacter()
    {

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            playerAnimator.SetTrigger("Jump");
            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, jumpForce);
        }
        if (isGrounded == false)
        {
            
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

    private void BetterJump()
    {
        if (rbPlayer.velocity.y < 0)
        {
            rbPlayer.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
        }
        if (rbPlayer.velocity.y > 0 && !Input.GetKey(KeyCode.W))
        {
            rbPlayer.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            enemyHealthBar.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            enemyHealthBar.SetActive(false);
        }
        
    }
    private void Shoot()
    {
        FindObjectOfType<Thrower>().Shoot();
    }
}
