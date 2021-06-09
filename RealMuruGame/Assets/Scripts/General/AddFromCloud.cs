using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class AddFromCloud : MonoBehaviour
{
    public AssetReference assetReference;

    private void Start()
    {
        assetReference.InstantiateAsync();
    }
}
