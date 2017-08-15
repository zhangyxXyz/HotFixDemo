using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PathUtil
{
    //资源资源地址（Assets文件夹）
    public static string APPLICATION_PATH = Application.dataPath;

    //用户自定义Res资源文件夹
    public static string USER_RES_PATH = Application.dataPath + "/Res";

    //Lua工程文件地址
    public static string LUA_SRC_PATH = APPLICATION_PATH + "/Src/Lua";

    //工程根目录地址
    public static string PROJECT_PATH = APPLICATION_PATH.Substring(0, APPLICATION_PATH.Length - 7);

    //AssetBundle打包的后缀名
    public static string SUFFIX_AB = "assetbundle";
    public static string SUFFIX_UNITY = "u3d";


    /// <summary>
    /// 获取assetbundle的输出目录
    /// </summary>
    /// <returns></returns>
    public static string GetAssetBundleOutPath()
    {
        string outPath = GetPlatformPath() + "/" + GetPlatformName();
        if (!Directory.Exists(outPath))
            Directory.CreateDirectory(outPath);
        return outPath;
    }

    /// <summary>
    /// 自动获取对应平台的路径
    /// </summary>
    /// <returns></returns>
    private static string GetPlatformPath()
    {
        switch (Application.platform)
        {
            case RuntimePlatform.WindowsPlayer:
            case RuntimePlatform.WindowsEditor:
                return Application.streamingAssetsPath;
            case RuntimePlatform.Android:
                return Application.persistentDataPath;
            default:
                return null;
        }
    }


    /// <summary>
    /// 获取对应平台的名字
    /// </summary>
    /// <returns></returns>
    public static string GetPlatformName()
    {
        switch (Application.platform)
        {
            case RuntimePlatform.WindowsPlayer:
            case RuntimePlatform.WindowsEditor:
                return "Windows";
            case RuntimePlatform.Android:
                return "Android";
            default:
                return null;
        }
    }


    /// <summary>
    /// 获取WWW协议的路径
    /// </summary>
    public static string GetWWWPath()
    {
        switch (Application.platform)
        {
            case RuntimePlatform.WindowsPlayer:
            case RuntimePlatform.WindowsEditor:
                return "file:///" + GetAssetBundleOutPath();
            case RuntimePlatform.Android:
                return "jar:file://" + GetAssetBundleOutPath();
            default:
                return null;
        }
    }
}
