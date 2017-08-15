using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void LoadProgress(string bundleName, float progress)
    {
        Debug.Log(progress + " : " + bundleName);
        if(progress >= 1f && bundleName == "charactor/mod.assetbundle")
        {
            Instantiate(AssetBundleManager.Instance.LoadAsset("Charactor", "Mod", "Max"));
        }
    }
    private void Start()
    {
        AssetBundleManager.Instance.LoadAssetBundle("Charactor", "Mod", LoadProgress);
    }
}
