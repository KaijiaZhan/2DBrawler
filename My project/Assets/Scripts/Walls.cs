using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    private Rigidbody2D rb;
    
    public void collide () {

    }

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
}
