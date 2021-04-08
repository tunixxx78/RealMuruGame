using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbBarrel;
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        
        rbBarrel.velocity = new Vector2(-speed, rbBarrel.velocity.y);

        if (rbBarrel.position.y < -5f)
        {
            Destroy(this.gameObject);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("Bottle"))
        {
            Destroy(gameObject);
        }
    }
}
