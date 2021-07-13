using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHealthbar : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameOverScreen;
    public int maxHealth = 100, currentHealth;

    public HealthBar playerHealthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        playerHealthBar.SetMaxHealth(maxHealth);

    }

    private void Update()
    {
        if (currentHealth <= 0f)
        {
            gameOverScreen.SetActive(true);
            Destroy(gameObject, 1.5f);
            
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        playerHealthBar.SetHealth(currentHealth);

    }



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Barrel"))
        {           
            TakeDamage(10);
            FindObjectOfType<SFXManager>().TakeHit();

        }

    }
    
}
