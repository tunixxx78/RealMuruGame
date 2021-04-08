using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawner : MonoBehaviour
{
    [SerializeField] private GameObject barrel;
    [SerializeField] private float spawnTime, spawnDelay;

    private void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(barrel, transform.position, transform.rotation);
    }

    public void StopSpawning()
    {
        CancelInvoke("SpawnObject");
    }


    
    
}
