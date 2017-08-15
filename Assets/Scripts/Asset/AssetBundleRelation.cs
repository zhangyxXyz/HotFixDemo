using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 管理 资源包的关系
/// </summary>
public class AssetBundleRelation
{
    /// <summary>
    /// 加载资源包
    /// </summary>
    private AssetBundleLoader assetBundleLoader;

    /// <summary>
    /// 包名
    /// </summary>
    private string bundleName;

    public string BundleName
    {
        get
        {
            return bundleName;
        }
    }

    /// <summary>
    /// 加载进度回调
    /// </summary>
    private LoadProgress lp;

    /// <summary>
    /// 加载进度回调
    /// </summary>
    public LoadProgress LoadProgess
    {
        get
        {
            return lp;
        }
    }

    private bool finish;
    /// <summary>
    /// 资源包是否加载完成
    /// </summary>
    public bool Finish
    {
        get
        {
            return finish;
        }
    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="bundleName"></param>
    /// <param name="lp"></param>
    public AssetBundleRelation(string bundleName, LoadProgress lp)
    {
        this.bundleName = bundleName;
        this.lp = lp;
        this.finish = false;
        assetBundleLoader = new AssetBundleLoader(onLoadComplete, lp, bundleName);
        dependenceBundleList = new List<string>();
        referenceBundleList = new List<string>();
    }

    /// <summary>
    /// 加载完成的回调
    /// </summary>
    /// <param name="bundleName"></param>
    private void onLoadComplete(string bundleName)
    {
        this.finish = true;
    }

    #region 依赖关系

    /// <summary>
    /// 所有依赖的包名
    /// </summary>
    private List<string> dependenceBundleList;

    /// <summary>
    /// 添加依赖关系
    /// </summary>
    /// <param name="bundleName"></param>
    public void AddDependence( string bundleName)
    {
        if (string.IsNullOrEmpty(bundleName))
            return;
        else if (dependenceBundleList.Contains(bundleName))
            return;
        else
            dependenceBundleList.Add(bundleName);
    }

    /// <summary>
    /// 移除依赖关系
    /// </summary>
    /// <param name="bundleName"></param>
    public void RemoveDependence(string bundleName)
    {
        if (dependenceBundleList.Contains(bundleName))
            dependenceBundleList.Remove(bundleName);
    }

    /// <summary>
    /// 获取所有的依赖关系
    /// </summary>
    /// <returns></returns>
    public string[] GetAllDependences()
    {
        return dependenceBundleList.ToArray();
    }

    #endregion


    #region 被依赖关系

    /// <summary>
    /// 所有被依赖的包名
    /// </summary>
    private List<string> referenceBundleList;

    /// <summary>
    /// 添加被依赖关系
    /// </summary>
    /// <param name="bundleName"></param>
    public void AddReference(string bundleName)
    {
        if (string.IsNullOrEmpty(bundleName))
            return;
        else if (referenceBundleList.Contains(bundleName))
            return;
        else
            referenceBundleList.Add(bundleName);
    }

    /// <summary>
    /// 移除被依赖关系
    /// </summary>
    /// <param name="bundleName"></param>
    /// <returns>true代表包被释放掉了 false代表包没被释放掉</returns>
    public bool RemoveReference(string bundleName)
    {
        if (referenceBundleList.Contains(bundleName))
        {
            referenceBundleList.Remove(bundleName);
            //移除一个包的时候 我们要做一个判断
            //还有没有被别的包所依赖
            //有  无所谓
            if (referenceBundleList.Count > 0)
                return false;
            else
            {
                //没有  就需要释放掉这个AssetBundle
                return true;
            }
        }
        else
            return false;
    }

    /// <summary>
    /// 获取所有的被依赖关系
    /// </summary>
    /// <returns></returns>
    public string[] GetAllReferences()
    {
        return referenceBundleList.ToArray();
    }

    #endregion


    /// <summary>
    /// 加载资源包
    /// </summary>
    /// <returns></returns>
    public IEnumerator Load()
    {
        yield return assetBundleLoader.Load();
    }

    /// <summary>
    /// 获取单个资源
    /// </summary>
    /// <param name="assetName">资源名字</param>
    /// <returns>Obj类型的资源</returns>
    public Object LoadAsset(string assetName)
    {
        if (assetBundleLoader == null)
        {
            Debug.LogError("当前assetBundleLoader为空，无法获取该 " + assetName + " 资源");
            return null;
        }

        return assetBundleLoader.LoadAsset(assetName);
    }


    /// <summary>
    /// 获取包里所有资源
    /// </summary>
    /// <returns></returns>
    public Object[] LoadAllAssets()
    {
        if (assetBundleLoader == null)
        {
            Debug.LogError("当前assetBundleLoader为空，无法获取资源");
            return null;
        }
        else
            return assetBundleLoader.LoadAllAssets();
    }

    /// <summary>
    /// 获取带有子物体的资源
    /// </summary>
    /// <param name="assetName">资源名称</param>
    /// <returns>所有资源</returns>
    public Object[] LoadAssetWithSubAssets(string assetName)
    {
        if (assetBundleLoader == null)
        {
            Debug.LogError("当前assetBundleLoader为空，无法获取该 " + assetName + " 资源");
            return null;
        }

        return assetBundleLoader.LoadAssetWithSubAssets(assetName);
    }

    /// <summary>
    /// 卸载资源
    /// </summary>
    /// <param name="asset">资源</param>
    public void UnLoadAsset(Object asset)
    {
        if (assetBundleLoader == null)
        {
            Debug.LogError("当前assetBundleLoader包为空");
        }
        else
            assetBundleLoader.UnLoadAsset(asset);
    }

    /// <summary>
    /// 释放资源包
    /// </summary>
    public void Dispose()
    {
        if (this.assetBundleLoader == null)
            return;

        assetBundleLoader.Dispose();
        assetBundleLoader = null;
    }

    /// <summary>
    /// 调试专用
    /// </summary>
    public void GetAllAssetNames()
    {
        assetBundleLoader.GetAllAssetNames();
    }
}
