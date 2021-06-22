using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreatJob : MonoBehaviour
{
    private int pointsToWin, currentPoints;
    public GameObject myObjects;

    private void Start()
    {
        currentPoints = 0;
        pointsToWin = myObjects.transform.childCount;
    }
    

    public void AddPoints()
    {
        currentPoints++;

        if (currentPoints >= pointsToWin)
        {
            //transform.GetChild(0).gameObject.SetActive(true);
            GameObject.Find("Canvas").GetComponent<Animator>().SetTrigger("win");
        }
    }
}
