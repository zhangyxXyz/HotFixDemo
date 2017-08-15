using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 资源缓存层，资源的二次加载，以节省性能
/// </summary>
public class AssetCaching
{
    /// <summary>
    /// 已经加载过的资源名称和 资源 的映射关系
    /// </summary>
    private Dictionary<string, TempObject> nameAssetDict;

    public AssetCaching()
    {
        nameAssetDict = new Dictionary<string, TempObject>();
    }

    public void AddAsset(string assetName, TempObject asset)
    {
        if(nameAssetDict.ContainsKey(assetName))
        {
            Debug.LogWarning("此 " + assetName + "已经加载");
            return;
        }
        //加入字典缓存
        nameAssetDict.Add(assetName, asset);
    }

    /// <summary>
    /// 获取缓存资源
    /// </summary>
    /// <param name="assetName"></param>
    /// <returns></returns>
    public Object[] GetAsset(string assetName)
    {
        if(nameAssetDict.ContainsKey(assetName))
        {
            return nameAssetDict[assetName].AssetList.ToArray();
        }
        else
        {
            Debug.LogError("此 " + assetName + "资源尚未加载，获取资源出错！");
            return null;
        }
    }

    /// <summary>
    /// 卸载指定资源名称对应的资源
    /// </summary>
    /// <param name="assetName"></param>
    public void UnloadAsset(string assetName)
    {
        if(nameAssetDict.ContainsKey(assetName))
        {
            nameAssetDict[assetName].UnloadAsset();
        }
        else
        {
            Debug.LogError("此 " + assetName + "资源尚未加载，卸载资源出错！");
        }
    }

    /// <summary>
    /// 卸载所有资源
    /// </summary>
    public void UnloadAllAssets()
    {
        foreach(string assetName in nameAssetDict.Keys)
        {
            UnloadAsset(assetName);
        }
        nameAssetDict.Clear();
    }
}
