using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    [SerializeField] private GameObject bottle, point;
    [SerializeField] private float launchForce, bottleLifeSpawn = 0.5f, spaceBetweenPoints, fireRate = 1f;
    [SerializeField] private Transform shotPoint;
    

    private GameObject[] points;
    [SerializeField] private int numberOfPoints;
    private Vector2 direction;
    private float nextFire = 0f;

    private void Start()
    {
        /*points = new GameObject[numberOfPoints];
        for (int i = 0; i<numberOfPoints; i++)
        {
            points[i] = Instantiate(point, shotPoint.position, Quaternion.identity);
        }*/
    }

    private void Update()
    {
        /*Vector2 bottlePosition = transform.position;                              //Tällä ampuminen hiiren osoittamaan paikkaan.
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePosition - bottlePosition;
        transform.up = direction;

        if (Input.GetMouseButtonDown(0) && Time.time >= nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }*/
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextFire)
        {
            nextFire = Time.time + fireRate;
            Shoot();
        }
        for (int i = 0; i < numberOfPoints; i++)
        {
            points[i].transform.position = PointPosition(i * spaceBetweenPoints);
        }
    }

    public void Shoot()
    {
        GameObject newBottle = Instantiate(bottle, shotPoint.position, shotPoint.rotation);
        newBottle.GetComponent<Rigidbody2D>().velocity = (transform.right + Vector3.up) * launchForce;
        if (newBottle)
        {
            Destroy(newBottle, bottleLifeSpawn);
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
