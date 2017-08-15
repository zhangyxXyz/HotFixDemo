using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

/// <summary>
/// 加载进度
/// </summary>
[CSharpCallLua]
public delegate void LoadProgress(string bundleName, float progress);

/// <summary>
/// 加载完成时候的调用
/// </summary>
public delegate void LoadComplete(string bundleName);

/// <summary>
/// 加载assetbundle的回调
/// </summary>
public delegate void LoadAssetBundleCallback(string sceneName, string bundleName);

public class AssetUtil
{

}
