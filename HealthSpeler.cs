using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using JetBrains.Annotations;

public class HealthSpeler : MonoBehaviour
{
    public static int maxHealth = 3;
    public static int currentHealth;

    public TMP_Text healthText;    

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthText();        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.collider.CompareTag("MinLeven"))
            {
                EnemyDamage enemyDamage = collision.collider.GetComponent<EnemyDamage>();

                if (enemyDamage != null)
                {
                    TakeDamage(enemyDamage.damageAmount);
                }
                else
                {
                    TakeDamage(1);
                }
            }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        UpdateHealthText();        

        if (currentHealth <= 0)
        {
            Die();
            SceneManager.LoadScene("Game Over");
        }
    }

    private void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Heal(int amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        UpdateHealthText();        
    }

    void UpdateHealthText()
    {
        if (healthText != null)
        {
            healthText.text = "Levens: " + currentHealth;
        }
    }
}