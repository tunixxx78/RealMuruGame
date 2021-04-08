using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;
    public int maxHealth = 100, currentHealth;

    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

    private void Update()
    {
        if (currentHealth <= 0f)
        { 
            Destroy(gameObject, 1f);
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Bottle"))
        {
            TakeDamage(10);

        }
        
    }
}
