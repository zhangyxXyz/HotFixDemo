using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 加载 AssetBundle
/// </summary>
public class AssetBundleLoader
{
    /// <summary>
    /// 包里的资源
    /// </summary>
    private AssetLoader assetLoader;

    /// <summary>
    /// WWW对象
    /// </summary>
    private WWW www;

    /// <summary>
    /// 包名
    /// </summary>
    private string bundleName;

    /// <summary>
    /// 包的路径
    /// </summary>
    private string bundlePath;

    /// <summary>
    /// 进度
    /// </summary>
    private float progress;

    /// <summary>
    /// 加载进度回调
    /// </summary>
    private LoadProgress lp;

    /// <summary>
    /// 加载完成回调
    /// </summary>
    private LoadComplete lc;

    /// <summary>
    /// 构造函数
    /// </summary>
    public AssetBundleLoader(LoadComplete lc, LoadProgress lp, string bundleName)
    {
        this.lc = lc;
        this.lp = lp;
        this.bundleName = bundleName;
        this.progress = 0f;

        this.bundlePath = PathUtil.GetWWWPath() + "/" + bundleName;
        this.www = null;
        this.assetLoader = null;
    }

    /// <summary>
    /// 加载资源包
    /// </summary>
    /// <returns></returns>
    public IEnumerator Load()
    {
        www = new WWW(bundlePath);

        //已经下载到本地，就不再使用www加载
        //AssetBundleCreateRequest abcr = AssetBundle.LoadFromFileAsync(bundlePath);
        //yield return abcr;

        while (!www.isDone)
        {
            this.progress = www.progress;

            //每一帧来调用一次 更新加载进度
            if (lp != null)
                lp(bundleName, progress);

            yield return www;
        }
        progress = www.progress;
        if (progress >= 1f)
        {
            //加载完成了
            assetLoader = new AssetLoader(www.assetBundle);
            //assetLoader.AssetBundle = www.assetBundle;

            //每一帧来调用一次 更新加载进度
            if (lp != null)
                lp(bundleName, progress);

            if (lc != null)
                lc(bundleName);
        }
    }


    /// <summary>
    /// 获取单个资源
    /// </summary>
    /// <param name="assetName">资源名字</param>
    /// <returns>Obj类型的资源</returns>
    public Object LoadAsset(string assetName)
    {
        if (assetLoader == null)
        {
            Debug.LogError("当前assetLoader为空，无法获取该 " + assetName + " 资源");
            return null;
        }

        return assetLoader.LoadAsset(assetName);
    }

    /// <summary>
    /// 获取包里所有资源
    /// </summary>
    /// <returns></returns>
    public Object[] LoadAllAssets()
    {
        if (assetLoader == null)
        {
            Debug.LogError("当前assetLoader为空，无法获取资源");
            return null;
        }
        else
            return assetLoader.LoadAllAssets();
    }

    /// <summary>
    /// 获取带有子物体的资源
    /// </summary>
    /// <param name="assetName">资源名称</param>
    /// <returns>所有资源</returns>
    public Object[] LoadAssetWithSubAssets(string assetName)
    {
        if (assetLoader == null)
        {
            Debug.LogError("当前assetLoader为空，无法获取该 " + assetName + " 资源");
            return null;
        }

        return assetLoader.LoadAssetWithSubAssets(assetName);
    }

    /// <summary>
    /// 卸载资源
    /// </summary>
    /// <param name="asset">资源</param>
    public void UnLoadAsset(Object asset)
    {
        if (assetLoader == null)
        {
            Debug.LogError("当前assetLoader包为空");
        }
        else
            assetLoader.UnLoadAsset(asset);
    }

    /// <summary>
    /// 释放资源包
    /// </summary>
    public void Dispose()
    {
        if (this.assetLoader == null)
            return;

        assetLoader.Dispose();
        assetLoader = null;
    }

    /// <summary>
    /// 调试专用
    /// </summary>
    public void GetAllAssetNames()
    {
        assetLoader.GetAllAssetNames();
    }

}
