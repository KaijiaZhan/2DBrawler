using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //[SerializeField] private float health;
    private Rigidbody2D rb;

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarScripti healthBar;
    float timer = 0f;
    float delay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0) {
                Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Trap") && Time.time>=timer) {
            TakeDamage(20);
            timer = Time.time + delay;
        }
    }
}
