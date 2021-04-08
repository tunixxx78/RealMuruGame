using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rbBottle;

    private void Update()
    {
        float angle = Mathf.Atan2(rbBottle.velocity.y, rbBottle.velocity.x * Mathf.Rad2Deg);
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
