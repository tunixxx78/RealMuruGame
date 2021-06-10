using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbBottle;
    [SerializeField] private float rotationSpeed = 4f, torque = 1f;

    [SerializeField] private GameObject winesplashParticle;

    private void Update()
    {
        float angle = Mathf.Atan2(rbBottle.velocity.y, rbBottle.velocity.x * Mathf.Rad2Deg);
        //transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        transform.Rotate(new Vector3(0, 0, -rotationSpeed));
        rbBottle.AddTorque(-torque * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(winesplashParticle, gameObject.transform.position, Quaternion.Euler(0,0,0));
        Destroy(this.gameObject);
    }
}
