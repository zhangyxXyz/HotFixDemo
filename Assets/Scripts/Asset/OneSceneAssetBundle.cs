using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 一个场景的所有资源的管理
/// </summary>
public class OneSceneAssetBundle
{
    /// <summary>
    /// 资源包的  包名-->资源关系  的映射
    /// </summary>
    private Dictionary<string, AssetBundleRelation> nameBundleDict;

    /// <summary>
    /// 资源包的  包名-->资源缓存  的映射
    /// </summary>
    private Dictionary<string, AssetCaching> nameCacheDict;

    /// <summary>
    /// 当前场景的名字
    /// </summary>
    private string sceneName;

    public OneSceneAssetBundle(string sceneName)
    {
        this.sceneName = sceneName;
        nameBundleDict = new Dictionary<string, AssetBundleRelation>();
        nameCacheDict = new Dictionary<string, AssetCaching>();
    }

    /// <summary>
    /// 是否已经加载了这个资源包
    /// </summary>
    /// <param name="bundleName"></param>
    /// <returns></returns>
    public bool IsLoading(string bundleName)
    {
        return nameBundleDict.ContainsKey(bundleName);
    }

    /// <summary>
    /// 资源包是否已经加载完成
    /// </summary>
    /// <param name="bundleName"></param>
    /// <returns></returns>
    public bool IsFinish(string bundleName)
    {
        if(IsLoading(bundleName))
        {
            return nameBundleDict[bundleName].Finish;
        }
        return false;
    }


    #region 加载资源包

    /// <summary>
    /// 加载资源包
    /// </summary>
    /// <param name="bundleName"></param>
    /// <param name="lp"></param>
    /// <param name="labcb"></param>
    public void LoadAssetBundle(string bundleName, LoadProgress lp, LoadAssetBundleCallback labcb)
    {
        if(nameBundleDict.ContainsKey(bundleName))
        {
            Debug.LogWarning("此包已经加载了 : " + bundleName);
            return;
        }
        else
        {
            //没有被加载，保存到字典里面
            AssetBundleRelation assetBundleRelation = new AssetBundleRelation(bundleName, lp);
            nameBundleDict.Add(bundleName, assetBundleRelation);

            //开始加载，由于没有继承子monobehaver，所以通过delegate来加载
            labcb(sceneName, bundleName);
        }
    }

    /// <summary>
    /// 加载包
    /// </summary>
    /// <param name="bundleName"></param>
    /// <returns></returns>
    public IEnumerator Load(string bundleName)
    {
        while (!AssetBundleManifestLoader.Instance.Finish)
        {
            yield return null;
        }
        AssetBundleRelation assetBundleRelation = nameBundleDict[bundleName];
        //获取当前资源包的所有依赖关系
        string[] dependenceBundles = AssetBundleManifestLoader.Instance.GetDependencies(bundleName);
        //添加对应的依赖关系
        foreach(var dependenceBundleName in dependenceBundles)
        {
            assetBundleRelation.AddDependence(dependenceBundleName);
            //添加被依赖关系并加载依赖项（必须先加载依赖项）
            yield return LoadDependence(dependenceBundleName, bundleName, assetBundleRelation.LoadProgess);
        }
        //开始加载
        yield return assetBundleRelation.Load();

    }

    /// <summary>
    /// 加载依赖项的资源包
    /// </summary>
    /// <param name="bundleName"></param>
    /// <param name="referenceBundleName"></param>
    /// <param name="lp"></param>
    /// <returns></returns>
    private IEnumerator LoadDependence(string bundleName, string referenceBundleName, LoadProgress lp)
    {
        //当前资源已经加载，直接添加被依赖关系
        if(nameBundleDict.ContainsKey(bundleName))
        {
            AssetBundleRelation assetBundleRelation = nameBundleDict[bundleName];
            assetBundleRelation.AddReference(referenceBundleName);
            yield return null;
        }
        //没有被加载，创建一个新的并加入字典
        else
        {
            AssetBundleRelation assetBundleRelation = new AssetBundleRelation(bundleName, lp);
            assetBundleRelation.AddReference(referenceBundleName);
            nameBundleDict.Add(bundleName, assetBundleRelation);
            //加载这个依赖项资源包
            yield return Load(bundleName);
        }
    }
    #endregion

    #region 加载资源
    
    //如果是第一次获取，采用AssetBundle.LoadAsset(assetName)，并加入缓存
    //第二次及以后直接到缓存读取

    /// <summary>
    /// 加载单个资源
    /// </summary>
    /// <param name="bundleName"></param>
    /// <param name="assetName"></param>
    /// <returns></returns>
    public Object LoadAsset(string bundleName, string assetName)
    {
        //先到缓存查找
        if(nameCacheDict.ContainsKey(bundleName))
        {
            Object[] assets = nameCacheDict[bundleName].GetAsset(assetName);
            //有可能比没有加入缓存，但资源已经加载
            if (assets != null)
            {
                return assets[0];
            }
        }

        //当前包没有被加载
        if(!nameBundleDict.ContainsKey(bundleName))
        {
            Debug.LogError("当前 " + bundleName + "包没有被加载，无法获取资源！");
            return null;
        }

        //当前包已经被加载
        Object asset = nameBundleDict[bundleName].LoadAsset(assetName);
        TempObject tmpAsset = new TempObject(asset);

        //有这个缓存层，并且里面有资源，但是这次获取的资源是之前没有缓存过的
        //直接添加
        if(nameCacheDict.ContainsKey(bundleName))
        {
            nameCacheDict[bundleName].AddAsset(assetName, tmpAsset);
        }
        else
        {
            //第一次获取这个包里面的资源
            AssetCaching catching = new AssetCaching();
            catching.AddAsset(assetName, tmpAsset);
            //保存到字典
            nameCacheDict.Add(bundleName, catching);
        }
        return asset;
    }

    /// <summary>
    /// 获取带有子物体的资源
    /// </summary>
    /// <param name="bundleName"></param>
    /// <param name="assetName">资源名称</param>
    /// <returns></returns>
    public Object[] LoadAssetWithSubAssets(string bundleName, string assetName)
    {
        //先到缓存查找
        if (nameCacheDict.ContainsKey(bundleName))
        {
            Object[] assets = nameCacheDict[bundleName].GetAsset(assetName);
            //有可能比没有加入缓存，但资源已经加载
            if (assets != null)
            {
                return assets;
            }
        }

        //当前包没有被加载
        if (!nameBundleDict.ContainsKey(bundleName))
        {
            Debug.LogError("当前 " + bundleName + "包没有被加载，无法获取资源！");
            return null;
        }

        //当前包已经被加载
        Object[] asset = nameBundleDict[bundleName].LoadAssetWithSubAssets(assetName);
        TempObject tmpAsset = new TempObject(asset);

        //有这个缓存层，并且里面有资源，但是这次获取的资源是之前没有缓存过的
        //直接添加
        if (nameCacheDict.ContainsKey(bundleName))
        {
            nameCacheDict[bundleName].AddAsset(assetName, tmpAsset);
        }
        else
        {
            //第一次获取这个包里面的资源
            AssetCaching catching = new AssetCaching();
            catching.AddAsset(assetName, tmpAsset);
            //保存到字典
            nameCacheDict.Add(bundleName, catching);
        }
        return asset;
    }

    /// <summary>
    /// 加载所有的资源
    /// </summary>
    /// <param name="bundleName"></param>
    /// <returns></returns>
    public Object[] LoadAllAssets(string bundleName)
    {
        if(!nameBundleDict.ContainsKey(bundleName))
        {
            Debug.LogError("当前 " + bundleName + " 包没有加载，无法获取资源");
            return null;
        }
        else
        {
            return nameBundleDict[bundleName].LoadAllAssets();
        }
    }
    #endregion

    #region 卸载

    public void UnLoadAsset(string bundleName, string assetName)
    {
        if (!nameCacheDict.ContainsKey(bundleName))
        {
            Debug.LogError("当前 " + bundleName + " 包没有缓存资源，无法卸载资源");
        }
        else
        {
            //已经缓存资源了 可以卸载
            nameCacheDict[bundleName].UnloadAsset(assetName);
            Resources.UnloadUnusedAssets();
        }
    }

    /// <summary>
    /// 卸载一个包里面的所有资源
    /// </summary>
    /// <param name="bundleName"></param>
    public void UnLoadAllAsset(string bundleName)
    {
        if (!nameCacheDict.ContainsKey(bundleName))
        {
            Debug.LogError("当前 " + bundleName + " 包没有缓存资源，无法卸载资源");
        }
        else
        {
            //已经缓存资源了 可以卸载
            nameCacheDict[bundleName].UnloadAllAssets();
            nameCacheDict.Remove(bundleName);
            Resources.UnloadUnusedAssets();
        }
    }

    /// <summary>
    /// 卸载所有的资源
    /// </summary>
    public void UnLoadAll()
    {
        foreach(var item in nameCacheDict.Keys)
        {
            UnLoadAllAsset(item);
        }
        nameCacheDict.Clear();
    }


    /// <summary>
    /// 卸载包
    /// </summary>
    public void Dispose(string bundleName)
    {
        if (!nameBundleDict.ContainsKey(bundleName))
        {
            Debug.LogError("当前 " + bundleName + " 包没有加载，无法获取资源");
            return;
        }

        //先获取到当前的包
        AssetBundleRelation assetBundleRelation = nameBundleDict[bundleName];

        //获取当前包的所有依赖关系
        string[] allDependences = assetBundleRelation.GetAllDependences();
        foreach (string dependenceBundleName in allDependences)
        {
            AssetBundleRelation tmpAssetBundle = nameBundleDict[dependenceBundleName];
            //首先 移除 依赖的包里面的被依赖关系
            if (tmpAssetBundle.RemoveReference(bundleName))
            {
                //递归
                Dispose(tmpAssetBundle.BundleName);
            }
        }

        //才开始卸载当前包
        if (assetBundleRelation.GetAllReferences().Length <= 0)
        {
            nameBundleDict[bundleName].Dispose();
            nameBundleDict.Remove(bundleName);
        }

    }

    /// <summary>
    /// 卸载所有包
    /// </summary>
    public void DisposeAll()
    {
        foreach (var item in nameBundleDict.Keys)
            Dispose(item);

        nameBundleDict.Clear();
    }

    /// <summary>
    ///  卸载所有包和资源
    /// </summary>
    public void DisposeAndUnLoadAll()
    {
        UnLoadAll();
        DisposeAll();
    }

    #endregion

    /// <summary>
    /// 调试专用
    /// </summary>
    /// <param name="bundleName"></param>
    public void GetAllAssetNames(string bundleName)
    {
        nameBundleDict[bundleName].GetAllAssetNames();
    }
}
