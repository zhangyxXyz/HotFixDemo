using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

/// <summary>
/// AssetBundle编辑
/// </summary>
public class AssetBundleEditor
{
    #region 自动打标签
    //思路
    //1.得到选中的资源文件夹(一级文件夹)
    //2.遍历里面的每个文件夹
    //3.遍历文件夹里的所有文件系统
    //4.如果访问的是文件夹：再继续访问里面的所有文件系统，直到找到文件 （递归）
    //5.找到文件 就要修改他的 assetbundle labels
    //6.用 AssetImporter 类 修改名称和后缀
    //7.保存对应的 文件夹名 和 具体路径 

    [MenuItem("AssetBundle/Set Select Asset Labels")]
    public static void SetSelectAssetLabels()
    {
        //1、获取当前所有选中目录(选中文件夹和预制体)
        Object[] SelectedAsset = Selection.GetFiltered(typeof(Object), SelectionMode.Assets | SelectionMode.ExcludePrefab);
        int len = SelectedAsset.Length;
        if (len == 0) return;
        //2、遍历每一个选中的一级文件
        for (int i = 0; i < len; ++i)
        //foreach (Object selectDirectoryInfo in SelectedAsset)
        {
            Object selectDirectoryInfo = SelectedAsset[i];
            //显示进度条
            EditorUtility.DisplayProgressBar("设置AssetBundleName名称", "正在设置AssetBundleName名称中...", 1.0f * i / len);
            string fullPath = PathUtil.PROJECT_PATH + "/" + AssetDatabase.GetAssetPath(selectDirectoryInfo);
            //Debug.Log(fullPath);
            DirectoryInfo select = new DirectoryInfo(fullPath);
            if (null == select)
            {
                Debug.Log(fullPath + "不存在！");
                return;
            }
            else
            {
                Dictionary<string, string> namePathDict = new Dictionary<string, string>();
                //3.遍历每一个选中文件夹的文件系统(子文件夹递归调用)
                int index = fullPath.LastIndexOf("/");
                string floderName = fullPath.Substring(index + 1);
                OnSelectFileSystemInfo(select, floderName, true, namePathDict);
                OnWriteConfig(floderName, namePathDict);
            }
        }
        //移除所有没有使用的标签名字,刷新文件,清除进度条
        AssetDatabase.RemoveUnusedAssetBundleNames();
        AssetDatabase.Refresh();
        EditorUtility.ClearProgressBar();
    }


    [MenuItem("AssetBundle/Set All Asset Labels")]
    public static void SetAllAssetLabels()
    {
        //1、获取当前所有选中目录(选中文件夹和预制体)
        string fullPath = PathUtil.USER_RES_PATH;
        //Debug.Log(fullPath);
        DirectoryInfo directoryInfo = new DirectoryInfo(fullPath);
        DirectoryInfo[] selectDirectories = directoryInfo.GetDirectories();
        //2、遍历Res文件夹下每一个子文件
        int len = selectDirectories.Length;
        for (int i = 0; i < len; ++i)
        {
            //显示进度条
            EditorUtility.DisplayProgressBar("设置AssetBundleName名称", "正在设置AssetBundleName名称中...", 1.0f * i / len);
            DirectoryInfo tmpDirectoryInfo = selectDirectories[i];
            string selectDirecroty = fullPath + "/" + tmpDirectoryInfo.Name;
            DirectoryInfo select = new DirectoryInfo(selectDirecroty);
            //Debug.Log(selectDirecroty);
            if (null == select)
            {
                Debug.LogError(selectDirecroty + " 不存在！");
                return;
            }
            else
            {
                Dictionary<string, string> namePathDict = new Dictionary<string, string>();
                //3.遍历每一个选中文件夹的文件系统
                int index = selectDirecroty.LastIndexOf("/");
                string floderName = selectDirecroty.Substring(index + 1);
                OnSelectFileSystemInfo(select, floderName, true, namePathDict);
                OnWriteConfig(floderName, namePathDict);
            }
        }
        //移除所有没有使用的标签名字,刷新文件，清除进度条
        AssetDatabase.RemoveUnusedAssetBundleNames();
        AssetDatabase.Refresh();
        EditorUtility.ClearProgressBar();
    }

    [MenuItem("AssetBundle/Clear All Asset Labels")]
    public static void ClearAllAssetLabels()
    {
        string fullPath = PathUtil.USER_RES_PATH;
        DirectoryInfo directoryInfo = new DirectoryInfo(fullPath);
        DirectoryInfo[] selectDirectories = directoryInfo.GetDirectories();
        int len = selectDirectories.Length;
        for (int i = 0; i < len; ++i)
        {
            //显示进度条
            EditorUtility.DisplayProgressBar("清除AssetBundleName名称", "正在清除AssetBundleName名称中...", 1.0f * i / len);
            DirectoryInfo tmpDirectoryInfo = selectDirectories[i];
            string selectDirecroty = fullPath + "/" + tmpDirectoryInfo.Name;
            DirectoryInfo select = new DirectoryInfo(selectDirecroty);
            //Debug.Log(selectDirecroty);
            if (null == select)
            {
                Debug.LogError(selectDirecroty + " 不存在！");
                return;
            }
            else
            {
                //遍历每一个选中文件夹的文件系统
                int index = selectDirecroty.LastIndexOf("/");
                string floderName = selectDirecroty.Substring(index + 1);
                OnSelectFileSystemInfo(select, floderName, false);
            }
        }
        //移除所有没有使用的标签名字,刷新文件，清除进度条
        AssetDatabase.RemoveUnusedAssetBundleNames();
        EditorUtility.ClearProgressBar();
    }

    /// <summary>
    /// 遍历文件夹里的所有文件系统
    /// </summary>
    /// <param name="fileSystemInfo"></param>
    /// <param name="sceneName"></param>
    /// <param name="namePathDict"></param>
    private static void OnSelectFileSystemInfo(FileSystemInfo fileSystemInfo, string floderName, bool isSet,  Dictionary<string, string> namePathDict = null)
    {
        if (!fileSystemInfo.Exists)
        {
            Debug.LogError(fileSystemInfo.FullName + " 不存在！");
            return;
        }
        DirectoryInfo directoryInfo = fileSystemInfo as DirectoryInfo;
        FileSystemInfo[] fileSystemInfos = directoryInfo.GetFileSystemInfos();
        foreach (var tmpFileSystemInfo in fileSystemInfos)
        {
            FileInfo fileInfo = tmpFileSystemInfo as FileInfo;
            if (fileInfo == null)
            {
                //强制转换失败，表示这是一个文件夹
                //继续递归调用，直到找到内层文件
                OnSelectFileSystemInfo(tmpFileSystemInfo, floderName, isSet, namePathDict);
            }
            else
            {
                //强制转换成功，表示这是一个文件
                //5.找到文件，修改文件 assetbundel labels
                //通过isSet，判断是否清除Asset Labels
                if (isSet)
                    SetAssetLabels(fileInfo, floderName, namePathDict);
                else
                    ClearAssetLabels(fileInfo, floderName);
            }
        }
    }

    /// <summary>
    /// 修改资源文件的 assetbundle labels
    /// </summary>
    /// <param name="fileInfo"></param>
    /// <param name="fileName"></param>
    /// <param name="namePathDict"></param>
    private static void SetAssetLabels(FileInfo fileInfo, string fileName, Dictionary<string, string> namePathDict)
    {
        //对于Unity生成的.meta文件无视
        if (fileInfo.Extension == ".meta")
            return;
        string bundleName = GetBundelName(fileInfo, fileName);
        //Debug.Log("BundleName: " + bundleName);
        string assetPath = fileInfo.FullName.Replace(@"\", "/").Substring(PathUtil.PROJECT_PATH.Length + 1);
        AssetImporter assetImporter = AssetImporter.GetAtPath(assetPath);
        //用 AssetImporter 类修改名称和后缀
        assetImporter.assetBundleName = bundleName.ToLower();
        if (fileInfo.Extension == ".unity")
            assetImporter.assetBundleVariant = PathUtil.SUFFIX_UNITY;
        else
            assetImporter.assetBundleVariant = PathUtil.SUFFIX_AB;

        //添加到字典里
        string folderName = bundleName.Contains("/") ? bundleName.Split('/')[1] : bundleName;
        //Debug.Log(folderName);

        string bundlePath = assetImporter.assetBundleName + "." + assetImporter.assetBundleVariant;
        if (!namePathDict.ContainsKey(folderName))
            namePathDict.Add(folderName, bundlePath);
    }

    /// <summary>
    /// 清除AssetBundle Labels
    /// </summary>
    /// <param name="fileInfo"></param>
    /// <param name="fileName"></param>
    private static void ClearAssetLabels(FileInfo fileInfo, string fileName)
    {
        //对于Unity生成的.meta文件无视
        if (fileInfo.Extension == ".meta")
            return;
        string assetPath = fileInfo.FullName.Replace(@"\", "/").Substring(PathUtil.PROJECT_PATH.Length + 1);
        AssetImporter assetImporter = AssetImporter.GetAtPath(assetPath);
        //用 AssetImporter 类修改名称和后缀
        assetImporter.assetBundleName = null;
    }

    /// <summary>
    /// 根据文件和文件夹名字得到资源的AssetName
    /// </summary>
    /// <param name="fileInfo"></param>
    /// <param name="fileName"></param>
    /// <returns></returns>
    private static string GetBundelName(FileInfo fileInfo, string fileName)
    {
        string windowsPath = fileInfo.FullName;
        //转换成Unity可识别路径
        string unityPath = windowsPath.Replace(@"\", "/");

        int index = unityPath.IndexOf(fileName) + fileName.Length;
        string bundlePath = unityPath.Substring(index + 1);
        //同一文件夹下资源lable名字相同（一类资源避免分包过细）
        if (bundlePath.Contains("/"))
        {
            string[] tmp = bundlePath.Split('/');
            return fileName + "/" + tmp[0];
        }
        else
        {
            return fileName;
        }
    }

    /// <summary>
    /// 记录Asset Label的配置
    /// </summary>
    /// <param name="sceneName"></param>
    /// <param name="namePathDict"></param>
    private static void OnWriteConfig(string floderName, Dictionary<string, string> namePathDict)
    {
        string path = PathUtil.GetAssetBundleOutPath() + "/" + floderName + "Record.txt";
        //Debug.Log(path);
        using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
        {
            //写二进制
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(namePathDict.Count);
                foreach (KeyValuePair<string, string> kv in namePathDict)
                    sw.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
    #endregion

    #region AssetBundle打包
    [MenuItem("AssetBundle/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
        string outPath = PathUtil.GetAssetBundleOutPath();
        BuildPipeline.BuildAssetBundles(outPath,
           BuildAssetBundleOptions.DeterministicAssetBundle | BuildAssetBundleOptions.ChunkBasedCompression,
           BuildTarget.StandaloneWindows64
           );
    }
    #endregion

    #region 一键删除
    [MenuItem("AssetBundle/Delete All")]
    public static void DeleteAll()
    {
        string outPath = PathUtil.GetAssetBundleOutPath();
        Directory.Delete(outPath, true);
        File.Delete(outPath + ".meta");
        AssetDatabase.Refresh();
    }
    #endregion

    #region MD5校验文件生成
    [MenuItem("ExtraTools/Create Check Files")]
    static void CreatCheckFiles()
    {
        string outPath = PathUtil.GetAssetBundleOutPath();
        string filePath = outPath + "/checkFiles.txt";
        //如果存在这个文件先删除
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
        List<string> fileList = new List<string>();
        ListFiles(new DirectoryInfo(outPath), ref fileList);

        FileStream fs = new FileStream(filePath, FileMode.CreateNew);
        StreamWriter sw = new StreamWriter(fs);
        int len = fileList.Count;
        for (int i = 0; i < len; ++i)
        {
            EditorUtility.DisplayProgressBar("生成校验文件", "正在生成校验文件中...", 1.0f * i / len);
            string file = fileList[i];
            string ext = Path.GetExtension(file);
            //忽略meta文件
            if (ext.EndsWith(".meta"))
            {
                continue;
            }
            string md5 = GameTools.GetFileMd5Value(file);
            //转换成相对路径
            string value = file.Replace(outPath + "/", string.Empty);
            sw.WriteLine(value + "|" + md5);
        }
        sw.Close();
        fs.Close();
        AssetDatabase.Refresh();
        EditorUtility.ClearProgressBar();
    }

    /// <summary>
    /// 遍历AssetBundle资源目录下的所有文件
    /// </summary>
    /// <param name="fileSystemInfo"></param>
    /// <param name="fileList"></param>
    static void ListFiles(FileSystemInfo fileSystemInfo, ref List<string> fileList)
    {
        DirectoryInfo directoryInfo = fileSystemInfo as DirectoryInfo;
        //获取所有的文件系统
        FileSystemInfo[] infos = directoryInfo.GetFileSystemInfos();
        foreach (var info in infos)
        {
            FileInfo fileInfo = info as FileInfo;
            //是文件
            if (null != fileInfo)
            {
                fileList.Add(fileInfo.FullName.Replace("\\", "/"));
            }
            else
            {
                ListFiles(info, ref fileList);
            }
        }
    }
    #endregion
}