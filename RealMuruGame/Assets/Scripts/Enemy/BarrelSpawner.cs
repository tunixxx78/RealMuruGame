using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSpawner : MonoBehaviour
{
    [SerializeField] private GameObject barrel;
    [SerializeField] private float spawnTime, spawnDelay;

    //barrel inside enemy character hierarcy
    [SerializeField] private GameObject enemyBarrel;

    public bool useAnimEvents = false;


    private void Start()
    {
        if (!useAnimEvents)
        {
            InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        }
        
    }

    public void SpawnObject()
    {
        Instantiate(barrel, transform.position, transform.rotation);
    }

    //call this from enemy attack animation
    public void SpawnBarrel()
    {
        Instantiate(barrel, enemyBarrel.transform.position, enemyBarrel.transform.rotation);
    }


    public void StopSpawning()
    {
        CancelInvoke("SpawnObject");
    }


    
    
}
