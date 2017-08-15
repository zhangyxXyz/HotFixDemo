using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

public class LuaManager : MonoBehaviour
{
    public static LuaManager Instance;
    private LuaEnv luaEnv = null;
    //对应名字的lua的代码
    Dictionary<string, byte[]> loaderDict = new Dictionary<string, byte[]>();
    private void Awake()
    {
        luaEnv = new LuaEnv();
        luaEnv.AddLoader(CustomLoader);
        Instance = this;
    }

    public void DoString(string chunk, string chunkName = "chunk", LuaTable env = null)
    {
        luaEnv.DoString(chunk, chunkName, env);
    }

    /// <summary>
    /// 自定义Loader
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    private byte[] CustomLoader(ref string fileName)
    {
        //获取lua文件所在目录
        string luaPath = PathUtil.LUA_SRC_PATH;
        Debug.Log("luaPath: " + luaPath);
        if (loaderDict.ContainsKey(fileName))
            return loaderDict[fileName];
        return ProcessDir(new DirectoryInfo(luaPath), fileName);
    }

    private byte[] ProcessDir(FileSystemInfo fileSystemInfo, string fileName)
    {
        DirectoryInfo directoryInfo = fileSystemInfo as DirectoryInfo;
        FileSystemInfo[] files = directoryInfo.GetFileSystemInfos();
        foreach (var item in files)
        {
            FileInfo file = item as FileInfo;
            if (file == null)
            {
                ProcessDir(item, fileName);
            }
            else
            {
                string tmpName = item.Name.Split('.')[0];
                if (item.Extension == ".meta" || tmpName != fileName)
                    continue;

                byte[] bytes = File.ReadAllBytes(file.FullName);
                loaderDict.Add(fileName, bytes);
                return bytes;
            }
        }
        return null;
    }

    /// <summary>
    /// 调用lua方法
    /// </summary>
    public object[] CallLuaFunction(string luaName, string methodName, params object[] args)
    {
        LuaTable table = luaEnv.Global.Get<LuaTable>(luaName);
        LuaFunction function = table.Get<LuaFunction>(methodName);
        return function.Call(args);
    }

   
}
