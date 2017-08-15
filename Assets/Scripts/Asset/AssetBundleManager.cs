/********************************************************************
	Filename: 		AssetBundleManager.cs
	Created:		2017/08/15 0:32
	Author:			Yunxing Zhang
	
	Description:	AssetBundle管理类
*********************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;


/// <summary>
/// AssetBundle管理类
/// </summary>

[LuaCallCSharp]
public class AssetBundleManager : MonoBehaviour
{
	private static AssetBundleManager instance;
	/// <summary>
	/// 单例模式
	/// </summary>
	public static AssetBundleManager Instance
	{
		get
		{
			return instance;
		}
	}

	/// <summary>
	/// 场景名 和 场景里面所有包的管理 的映射
	/// </summary>
	Dictionary<string, SceneManager> nameSceneDict = new Dictionary<string, SceneManager>();

	void Awake()
	{
		instance = this;
		//先加载manifest文件
		StartCoroutine(AssetBundleManifestLoader.Instance.Load());
	}

	void OnDestroy()           
	{
		nameSceneDict.Clear();
		Resources.UnloadUnusedAssets();
		System.GC.Collect();
	}

	/// <summary>
	/// 加载资源包
	/// </summary>
	/// <param name="sceneName"></param>
	/// <param name="folderName"></param>
	/// <param name="lp"></param>
	public void LoadAssetBundle(string sceneName, string folderName, LoadProgress lp)
	{
		if (!nameSceneDict.ContainsKey(sceneName))
		{
			//如果没有这个场景 先创建这个场景 再读取一下 
			CreateSceneAssetBundles(sceneName);
		}

		SceneManager sceneManager = nameSceneDict[sceneName];
		//开始加载
		sceneManager.LoadAssetBundle(folderName, lp, LoadAssetBundleCallback);
	}


	/// <summary>
	/// 创建一个场景对应的包
	/// </summary>
	/// <param name="sceneName"></param>
	private void CreateSceneAssetBundles(string sceneName)
	{
		SceneManager scene = new SceneManager(sceneName);
		//读取记录文件
		scene.ReadRecord(sceneName);
		nameSceneDict.Add(sceneName, scene);
	}


	/// <summary>
	/// 加载资源包的回调
	/// </summary>
	/// <param name="sceneName"></param>
	/// <param name="bundleName"></param>
	private void LoadAssetBundleCallback(string sceneName, string bundleName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			StartCoroutine(sceneManager.Load(bundleName));
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
		}
	}

	/// <summary>
	/// 获取完整包名
	/// </summary>
	public string GetBundleName(string sceneName, string folderName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];
			return sceneManager.GetBundleName(folderName);
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
			return null;
		}
	}


	/// <summary>
	/// 是否加载了这个包
	/// </summary>
	/// <param name="folderName">文件夹名</param>
	/// <returns></returns>
	public bool IsLoading(string sceneName, string folderName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			return sceneManager.IsLoading(folderName);
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
			return false;
		}
	}


	/// <summary>
	/// 是否加载完成这个包
	/// </summary>
	/// <param name="folderName">文件夹名</param>
	/// <returns></returns>
	public bool IsFinsh(string sceneName, string folderName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			return sceneManager.IsFinsh(folderName);
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
			return false;
		}
	}

	#region 下层提供的方法

	/// <summary>
	/// 获取单个资源
	/// </summary>
	/// <param name="assetName">资源名字</param>
	/// <returns>Obj类型的资源</returns>
	public Object LoadAsset(string sceneName, string folderName, string assetName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			return sceneManager.LoadAsset(folderName, assetName);
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
			return null;
		}
	}

	/// <summary>
	/// 获取包里所有资源
	/// </summary>
	/// <returns></returns>
	public Object[] LoadAllAssets(string sceneName, string folderName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			return sceneManager.LoadAllAssets(folderName);
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
			return null;
		}
	}

	/// <summary>
	/// 获取带有子物体的资源
	/// </summary>
	/// <param name="assetName">资源名称</param>
	/// <returns>所有资源</returns>
	public Object[] LoadAssetWithSubAssets(string sceneName, string folderName, string assetName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			return sceneManager.LoadAssetWithSubAssets(folderName, assetName);
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
			return null;
		}
	}


	/// <summary>
	/// 卸载资源
	/// </summary>
	/// <param name="asset">资源</param>
	public void UnLoadAsset(string sceneName, string folderName, string assetName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			sceneManager.UnLoadAsset(folderName, assetName);
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
		}
	}

	/// <summary>
	/// 卸载一个包里面的所有资源
	/// </summary>
	/// <param name="bundleName"></param>
	public void UnLoadAllAsset(string sceneName, string folderName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			sceneManager.UnLoadAllAsset(folderName);
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
		}
	}

	/// <summary>
	/// 卸载所有的资源
	/// </summary>
	public void UnLoadAll(string sceneName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			sceneManager.UnLoadAll();
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
		}
	}

	/// <summary>
	/// 卸载包
	/// </summary>
	public void Dispose(string sceneName, string folderName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			sceneManager.Dispose(folderName);
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
		}
	}

	/// <summary>
	/// 卸载所有的资源
	/// </summary>
	public void DisposeAll(string sceneName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			sceneManager.DisposeAll();
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
		}
	}

	/// <summary>
	///  卸载所有包和资源
	/// </summary>
	public void DisposeAndUnLoadAll(string sceneName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];
			sceneManager.DisposeAndUnLoadAll();
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
		}
	}

	/// <summary>
	/// 调试专用
	/// </summary>
	public void GetAllAssetNames(string sceneName, string folderName)
	{
		if (nameSceneDict.ContainsKey(sceneName))
		{
			SceneManager sceneManager = nameSceneDict[sceneName];

			sceneManager.GetAllAssetNames(folderName);
		}
		else
		{
			Debug.LogError("不存在这个场景 : " + sceneName);
		}
	} 
	#endregion
}
