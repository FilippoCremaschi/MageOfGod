using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public Transform player;
    public Transform target;
    public Movement playerMovement;
    public GameObject shotPrefab;
    float distanceFromTarget;
    float shotAngle = 30f;
    float fireTimer = 1f;
    float fireRate = 1f;

    // Update is called once per frame
    void Update()
    {
        calculateShotAngle();
    }

    void FixedUpdate()
    {
        if(playerMovement.horizontalMove == 0f)
        {
            fireTimer -= Time.fixedDeltaTime;
            if (fireTimer <= 0f)
            {
                fireTimer = fireRate;
                shoot();
            }
        }
    }

    void calculateShotAngle()
    {
        //distanceFromTarget = Vector3.Distance(player.position, target.position);
        //shotAngle += playerMovement.horizontalMove;
        //firePoint.rotation = quaternion.AxisAngle(new Vector3(0f, 0f, 1f), shotAngle);
    }
    void shoot()
    {
        Instantiate(shotPrefab, firePoint.position, firePoint.rotation);
    }

    
}
