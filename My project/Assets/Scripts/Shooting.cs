using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{

    public Transform shootingPoint;
    public GameObject bulletPrefab;
    float timer = 0;
    float shootDelay = 0.2f;

   void Update()
    {
        if (Input.GetMouseButtonDown(1) && Time.time>=timer)
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
            timer = Time.time + shootDelay;
        }
    }

}
