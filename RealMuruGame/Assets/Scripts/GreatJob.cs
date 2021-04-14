using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatJob : MonoBehaviour
{
    private int pointsToWin, currentPoints;
    public GameObject myObjects;

    private void Start()
    {
        pointsToWin = myObjects.transform.childCount;
    }
    private void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    public void AddPoints()
    {
        currentPoints++;
    }
}
