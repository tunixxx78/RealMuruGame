using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    [SerializeField] private GameObject bottle, point, canShoot, cantShoot, player;
    [SerializeField] private float launchForce, bottleLifeSpawn = 5f, spaceBetweenPoints, fireRate = 1f;
    [SerializeField] private Transform shotPoint;
    [SerializeField] private Animator attackAnimator;
    

    private GameObject[] points;
    [SerializeField] private int numberOfPoints;
    private Vector2 direction;
    private float nextFire = 0f;


    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFire && player.transform.localScale.x != -1f)
        {
            attackAnimator.SetTrigger("Attack");
            canShoot.SetActive(false);
            cantShoot.SetActive(true);
            nextFire = Time.time + fireRate;
        }
        if (Time.time >= nextFire)
        {
            cantShoot.SetActive(false);
            canShoot.SetActive(true);
        }
        
    }

    public void ThrowNow()
    {
        if(Time.time >= nextFire && player.transform.localScale.x != -1f)
        {
            attackAnimator.SetTrigger("Attack");
            canShoot.SetActive(false);
            cantShoot.SetActive(true);
            nextFire = Time.time + fireRate;
        }

        if (Time.time >= nextFire)
        {
            cantShoot.SetActive(false);
            canShoot.SetActive(true);
        }
    }

    public void Shoot()
    {
        GameObject newBottle = Instantiate(bottle, shotPoint.position, shotPoint.rotation);
        newBottle.GetComponent<Rigidbody2D>().velocity = (-transform.right + Vector3.up) * launchForce;
        if (newBottle)
        {
            Destroy(newBottle, 4f);
        }
    }

    public void ShootLeft()
    {
        GameObject newBottle = Instantiate(bottle, shotPoint.position, shotPoint.rotation);
        newBottle.GetComponent<Rigidbody2D>().velocity = (-transform.right + Vector3.up) * launchForce;
        if (newBottle)
        {
            Destroy(newBottle, bottleLifeSpawn);
        }
    }

    Vector2 PointPosition(float t)
    {
        Vector2 position = (Vector2)shotPoint.position + (direction.normalized * launchForce * t) + 0.5f * Physics2D.gravity * (t * t);
        return position;
    }

    
}
