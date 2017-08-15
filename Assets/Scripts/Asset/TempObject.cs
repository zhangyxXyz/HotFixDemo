using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempObject
{
    /// <summary>
    /// 资源列表
    /// </summary>
    private List<Object> assetList;
    public TempObject(params Object[] assets)
    {
        this.assetList = new List<Object>(assets);
    }

    public List<Object> AssetList
    {
        get
        {
            return assetList;
        }
    }

    /// <summary>
    /// 卸载资源
    /// </summary>
    public void UnloadAsset()
    {
        for(int i = this.AssetList.Count -1;i>=0;--i)
        {
            Resources.UnloadAsset(AssetList[i]);
        }
    }
}