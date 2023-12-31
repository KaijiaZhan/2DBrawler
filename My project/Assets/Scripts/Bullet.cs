using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   public float speed;
   private Rigidbody2D rb;

   void Start () {
    rb = GetComponent<Rigidbody2D>();
    rb.velocity = transform.right * speed;
   }

   private void OnTriggerEnter2D(Collider2D collision) {
      Dummy dummy = collision.GetComponent<Dummy>();
      Walls walls = collision.GetComponent<Walls>();
      if (dummy != null) {
         dummy.TakeDamage(20);
         Destroy(gameObject);
      }

      else if (walls != null) {
         walls.collide();
         Destroy(gameObject);
      }

   }
}
