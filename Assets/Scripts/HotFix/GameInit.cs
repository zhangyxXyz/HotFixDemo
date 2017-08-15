/********************************************************************
	Filename: 		GameInit.cs
	Created:		2017/08/15 14:55
	Author:			Yunxing Zhang
	
	Description:	游戏初始化
*********************************************************************/
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

/// <summary>
/// 这个脚本最先执行
/// </summary>
public class GameInit:MonoBehaviour
{
	/// <summary>
	/// 文件下载路径
	/// </summary>
	private string downloadPath;
	private void Awake()
	{
		//检测资源进行比对
		downloadPath = PathUtil.GetAssetBundleOutPath();
		StartCoroutine(downloadRes4Test());

		//初始化
		gameObject.AddComponent<AssetBundleManager>();
		gameObject.AddComponent<LuaManager>();
		LuaManager.Instance.DoString("require 'main'");
		LuaManager.Instance.CallLuaFunction("main", "init");
	}

	/// <summary>
	///  检测资源进行比对更新 (模拟测试 本机 用)
	/// </summary>
	private IEnumerator downloadRes4Test()
	{
		//这里 是 随便写的
		string url = "C:/LuaServer";
		string fileUrl = url + "/checkFiles.txt";
		//判断本地有没有这个目录
		if (!Directory.Exists(downloadPath))
			Directory.CreateDirectory(downloadPath);
		//读取里面的内容
		string[] lines = File.ReadAllLines(fileUrl);
		for (int i = 0; i < lines.Length; i++)
		{
			if (string.IsNullOrEmpty(lines[i]))
				continue;

			string[] kv = lines[i].Split('|');
			string fileName = kv[0];
			//再拿到本地的这个文件
			string localFile = (downloadPath + "/" + fileName).Trim();
			//如果本地文件没有 需要下载了
			if (!File.Exists(localFile))
			{
				//Debug.Log("本地没有 " + fileName + " 去服务器下载了");
				string dir = Path.GetDirectoryName(localFile);
				Directory.CreateDirectory(dir);
				
				string tmpUrl = url + "/" + fileName;
				File.Copy(tmpUrl, localFile, true);
			}
			else //如果文件有  开始比对md5 作用：检测是否更新了
			{
				string md5 = kv[1];
				string localMd5 = GameTools.GetFileMd5Value(localFile);
				if (md5 == localMd5)
				{
					//如果 md5 一样的话，那么就没更新 
					//Debug.Log("本地有 " + fileName + " 而且没更新");
				}
				else
				{
					//Debug.Log("本地有" + fileName + " 但是更新了 去服务器下载了");
					//如果不一样的话 说明更新了，删除本地原来的旧文件
					File.Delete(localFile);
					//拷贝本地新文件
					string tmpUrl = url + "/" + fileName;
					File.Copy(tmpUrl, localFile, true);
				}
			}
		}
		yield return new WaitForEndOfFrame();
		Debug.Log("游戏更新完成！");
	}


	/// <summary>
	/// 检测资源更新
	/// </summary>
	/// <returns></returns>
	private IEnumerator DownloadRes()
	{
		//随便写的（可通过读取配置文件得到）
		string url = "http://127.0.0.1:8888/path/";
		string fileUrl = url + "/checkFiles.txt";
		WWW www = new WWW(fileUrl);
		yield return www;
		if(null != www.error)
		{
			Debug.LogError(www.error);
		}

		//判断本地是否有这个文件
		//在手机上StreamAssets只有只读权限，一运行 就把此目录文件拷贝到persistentDataPath
		if(!Directory.Exists(downloadPath))
		{
			Directory.CreateDirectory(downloadPath);
		}
		//把下载的校验文件写入本地
		File.WriteAllBytes(downloadPath + "/checkFiles.txt", www.bytes);

		//读取内容进行比对
		string filesText = www.text;
		string[] lines = filesText.Split('\n');

		for(int i = 0;i<lines.Length;++i)
		{
			if(string.IsNullOrEmpty(lines[i]))
				continue;
			string[] kv = lines[i].Split('|');
			string fileName = kv[0];
			//再拿到本地的这个文件
			string localFile = (downloadPath + "/" + fileName).Trim();
			//是否需要从网络上下载文件
			bool isNeedDownload = false;
			//如果本地文件没有 需要下载了
			if (!File.Exists(localFile))
			{
				string dir = Path.GetDirectoryName(localFile);
				Directory.CreateDirectory(dir);
				isNeedDownload = true;
			}
			else//如果存在本地文件开始MD5比对
			{
				string md5 = kv[1];
				string localMd5 = GameTools.GetFileMd5Value(localFile);
				if (md5 != localMd5)
				{
					//如果不一样的话 说明更新了 
					//删除本地原来的旧文件
					File.Delete(localFile);
					//下载新文件
					isNeedDownload = true;
				}
			}
			if(isNeedDownload)
			{
				//下载网络文件
				string tmpUrl = url + fileName;
				www = new WWW(tmpUrl);
				yield return www;
				//进行一些网络的检测
				if (www.error != null)
					Debug.LogError(www.error);
				File.WriteAllBytes(localFile, www.bytes);
			}
		}
		yield return new WaitForEndOfFrame();
		Debug.Log("更新完成，可以开始游戏了");
	}
}
