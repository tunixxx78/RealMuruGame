using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerManager : MonoBehaviour
{
    public Transform worldEdgeLeft, worldEdgeRight;
    public static LayerManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
