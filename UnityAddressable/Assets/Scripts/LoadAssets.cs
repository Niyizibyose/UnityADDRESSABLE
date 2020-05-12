using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class LoadAssets : MonoBehaviour
{
    public AssetReference assetReference;
    void Start()
    {
        assetReference.InstantiateAsync();
        //Addressables.LoadScene("AddressablesTut");
    }
}
