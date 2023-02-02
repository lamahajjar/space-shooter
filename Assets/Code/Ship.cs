using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ship : MonoBehaviour
{
    public Rigidbody2D myrigidbody2D;
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    // projectile
    // projectile spawn point
    public float acceleration;
    public float maxSpeed;
    public int maxArmor;
    public float fireRate;
    public float projectileSpeed;

    public float currentSpeed;
    public int currentArmor;
     public void thrust()
    {


    }


    public void Fireprojectile()
    {

    }


    public void Thrust()
    {
        myrigidbody2D.AddForce(transform.up * acceleration);
    }

    private void FixedUpdate()
    {
        if (myrigidbody2D.velocity.magnitude > maxSpeed)
        {
            myrigidbody2D.velocity = myrigidbody2D.velocity.normalized * maxSpeed;
        }
    }

    public void FireProjectile()
    {
       GameObject projectile = Instantiate(projectilePrefab, projectileSpawnPoint.position, transform.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce( transform.up * projectileSpeed);
    }

    public void TakeDamage()
    {

    }

    public void Expload()
    {

    }

}