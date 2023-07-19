using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
    
    [SerializeField] private float health;
    private Rigidbody2D rb;
    
    public void TakeDamage (float damage) {
        health -= damage;
        if (health <= 0) {
            Destroy(gameObject);
        }
    }

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

}

