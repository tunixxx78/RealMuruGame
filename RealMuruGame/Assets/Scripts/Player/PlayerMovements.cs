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
    private JoystickManager _joystickManager;
    

  
    
    private bool isGrounded = false;

    private void Start()
    {
        _joystickManager = GameObject.Find("JoystickBackground").GetComponent<JoystickManager>();
    }

    private void Update()
    {
        
        Move();
        Jump();
        CheckIfGrounded();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
    }


    public void Move()
    {
        //float x = Input.GetAxisRaw("Horizontal");
        float x = _joystickManager.inputHorizontal();
        float moveBy = x * speed;
        rbPlayer.velocity = new Vector2(moveBy, rbPlayer.velocity.y);

        playerAnimator.SetBool("Run", x != 0f);

        Vector3 characterScale = transform.localScale;
        
        if (x > 0)
        {
           
            characterScale.x = 1f;
            
        }
        if (x < 0)
        {
            characterScale.x = -1f;
            
        }
        transform.localScale = characterScale;
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            //playerAnimator.SetTrigger("Jump");
            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, jumpForce);
            SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.jump);
        }
        if (isGrounded == false)
        {
            
        }
        CheckIfGrounded();
        
        playerAnimator.SetBool("InAir", rbPlayer.velocity.y != 0);
        //playerAnimator.SetBool("InAir", false);
        
    }
    public void JumpNow()
    {
        if(isGrounded)
        {
            rbPlayer.velocity = new Vector2(rbPlayer.velocity.x, jumpForce);
            SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.jump);
        }
        

        if (isGrounded == false)
        {

        }
        CheckIfGrounded();

        playerAnimator.SetBool("InAir", rbPlayer.velocity.y != 0);
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

    private void OnTriggerEnter2D(Collider2D collision)
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

    public void RunSound()
    {
        FindObjectOfType<SFXManager>().WalkSounds();
    }

    public void MobileThrow()
    {
        FindObjectOfType<Thrower>().ThrowNow();
    }
}
