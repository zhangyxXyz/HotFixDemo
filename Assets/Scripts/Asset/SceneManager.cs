using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// 场景里面所有包的管理 （通过Record文件读取文件夹名字 转换成 包名）
/// </summary>
public class SceneManager
{

    /// <summary>
    /// 一个场景里面所有的资源包
    /// </summary>
    private OneSceneAssetBundle sceneAssetBundles;

    /// <summary>
    /// 文件夹名 和 包名 的映射
    /// </summary>
    private Dictionary<string, string> folderBundleDict;

    /// <summary>
    /// 构造函数
    /// </summary>
    public SceneManager(string sceneName)
    {
        sceneAssetBundles = new OneSceneAssetBundle(sceneName);
        folderBundleDict = new Dictionary<string, string>();
    }

    /// <summary>
    /// 读取记录文件
    /// </summary>
    /// <param name="sceneName">场景名</param>
    public void ReadRecord(string sceneName)
    {
        //获取记录文件的路径
        string path = PathUtil.GetAssetBundleOutPath() + "/" + sceneName + "Record.txt";

        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            using (StreamReader sr = new StreamReader(fs))
            {
                //读取多少行
                int count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    string line = sr.ReadLine();
                    string[] kv = line.Split(' ');
                    //添加到数组里面
                    folderBundleDict.Add(kv[0], kv[1]);
                }
            }
        }
    }

    /// <summary>
    /// 获取完整包名
    /// </summary>
    /// <param name="folderName">文件夹名</param>
    /// <returns></returns>
    public string GetBundleName(string folderName)
    {
        if (!folderName.Contains(folderName))
        {
            Debug.LogError("没有这个文件夹 : " + folderName);
            return null;
        }

        return folderBundleDict[folderName];
    }

    /// <summary>
    /// 是否加载了这个包
    /// </summary>
    /// <param name="folderName">文件夹名</param>
    /// <returns></returns>
    public bool IsLoading(string folderName)
    {
        if (folderBundleDict.ContainsKey(folderName))
        {
            //获取包名
            string bundleName = folderBundleDict[folderName];
            //开始加载
            return sceneAssetBundles.IsLoading(bundleName);
        }
        else
        {
            Debug.LogError("找不到这个文件夹 " + folderName + " 对应的包");
            return false;
        }
    }

    /// <summary>
    /// 是否加载完成这个包
    /// </summary>
    /// <param name="folderName">文件夹名</param>
    /// <returns></returns>
    public bool IsFinsh(string folderName)
    {

        if (folderBundleDict.ContainsKey(folderName))
        {
            //获取包名
            string bundleName = folderBundleDict[folderName];
            //开始加载
            return sceneAssetBundles.IsFinish(bundleName);
        }
        else
        {
            Debug.LogError("找不到这个文件夹 " + folderName + " 对应的包");
            return false;
        }
    }

    /// <summary>
    /// 加载资源包
    /// </summary>
    /// <param name="folderName">文件夹名</param>
    /// <param name="lp"></param>
    /// <param name="labcb"></param>
    public void LoadAssetBundle(string folderName, LoadProgress lp, LoadAssetBundleCallback labcb)
    {
        if (folderBundleDict.ContainsKey(folderName))
        {
            //获取包名
            string bundleName = folderBundleDict[folderName];
            //开始加载
            sceneAssetBundles.LoadAssetBundle(bundleName, lp, labcb);
        }
        else
        {
            Debug.LogError("找不到这个文件夹 " + folderName + " 对应的包");
        }
    }


    /// <summary>
    /// 加载包
    /// </summary>
    /// <param name="bundleName">包名</param>
    /// <returns></returns>
    public IEnumerator Load(string bundleName)
    {
        yield return sceneAssetBundles.Load(bundleName);
    }

    /// <summary>
    /// 获取单个资源
    /// </summary>
    /// <param name="assetName">资源名字</param>
    /// <returns>Obj类型的资源</returns>
    public Object LoadAsset(string folderName, string assetName)
    {
        if (sceneAssetBundles == null)
        {
            Debug.LogError("当前 sceneAssetBundles 为空，无法获取该 " + assetName + " 资源");
            return null;
        }

        if (folderBundleDict.ContainsKey(folderName))
        {
            //获取包名
            string bundleName = folderBundleDict[folderName];

            return sceneAssetBundles.LoadAsset(bundleName, assetName);
        }
        else
        {
            Debug.LogError("找不到这个文件夹 " + folderName + " 对应的包");
            return null;
        }
    }

    /// <summary>
    /// 获取包里所有资源
    /// </summary>
    /// <returns></returns>
    public Object[] LoadAllAssets(string folderName)
    {
        if (sceneAssetBundles == null)
        {
            Debug.LogError("当前 sceneAssetBundles 为空，无法获取该资源");
            return null;
        }

        if (folderBundleDict.ContainsKey(folderName))
        {
            //获取包名
            string bundleName = folderBundleDict[folderName];

            return sceneAssetBundles.LoadAllAssets(bundleName);
        }
        else
        {
            Debug.LogError("找不到这个文件夹 " + folderName + " 对应的包");
            return null;
        }
    }

    /// <summary>
    /// 获取带有子物体的资源
    /// </summary>
    /// <param name="assetName">资源名称</param>
    /// <returns>所有资源</returns>
    public Object[] LoadAssetWithSubAssets(string folderName, string assetName)
    {
        if (sceneAssetBundles == null)
        {
            Debug.LogError("当前 sceneAssetBundles 为空，无法获取该 " + assetName + " 资源");
            return null;
        }

        if (folderBundleDict.ContainsKey(folderName))
        {
            //获取包名
            string bundleName = folderBundleDict[folderName];

            return sceneAssetBundles.LoadAssetWithSubAssets(bundleName, assetName);
        }
        else
        {
            Debug.LogError("找不到这个文件夹 " + folderName + " 对应的包");
            return null;
        }
    }


    /// <summary>
    /// 卸载资源
    /// </summary>
    /// <param name="asset">资源</param>
    public void UnLoadAsset(string folderName, string assetName)
    {
        if (folderBundleDict.ContainsKey(folderName))
        {
            //获取包名
            string bundleName = folderBundleDict[folderName];

            sceneAssetBundles.UnLoadAsset(bundleName, assetName);
        }
        else
        {
            Debug.LogError("找不到这个文件夹 " + folderName + " 对应的包");
        }
    }

    /// <summary>
    /// 卸载一个包里面的所有资源
    /// </summary>
    /// <param name="bundleName"></param>
    public void UnLoadAllAsset(string folderName)
    {
        if (folderBundleDict.ContainsKey(folderName))
        {
            //获取包名
            string bundleName = folderBundleDict[folderName];

            sceneAssetBundles.UnLoadAllAsset(bundleName);
        }
        else
        {
            Debug.LogError("找不到这个文件夹 " + folderName + " 对应的包");
        }
    }

    /// <summary>
    /// 卸载所有的资源
    /// </summary>
    public void UnLoadAll()
    {
        sceneAssetBundles.UnLoadAll();
    }

    /// <summary>
    /// 卸载包
    /// </summary>
    public void Dispose(string folderName)
    {
        if (folderBundleDict.ContainsKey(folderName))
        {
            //获取包名
            string bundleName = folderBundleDict[folderName];

            sceneAssetBundles.Dispose(bundleName);
        }
        else
        {
            Debug.LogError("找不到这个文件夹 " + folderName + " 对应的包");
        }
    }

    /// <summary>
    /// 卸载所有的资源
    /// </summary>
    public void DisposeAll()
    {
        sceneAssetBundles.DisposeAll();
    }

    /// <summary>
    ///  卸载所有包和资源
    /// </summary>
    public void DisposeAndUnLoadAll()
    {
        sceneAssetBundles.DisposeAndUnLoadAll();
    }

    /// <summary>
    /// 调试专用
    /// </summary>
    public void GetAllAssetNames(string folderName)
    {
        if (folderBundleDict.ContainsKey(folderName))
        {
            //获取包名
            string bundleName = folderBundleDict[folderName];

            sceneAssetBundles.GetAllAssetNames(bundleName);
            Debug.Log(bundleName);
        }
        else
        {
            Debug.LogError("找不到这个文件夹 " + folderName + " 对应的包");
        }
    }
}
