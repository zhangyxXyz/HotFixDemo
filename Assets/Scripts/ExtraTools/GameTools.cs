using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine;

public class GameTools
{

    /// <summary>
    /// 得到文件的MD5值
    /// </summary>
    /// <param name="filePath"></param>
    /// <returns></returns>
    public static string GetFileMd5Value(string filePath)
    {
        FileStream fs = new FileStream(filePath, FileMode.Open);
        MD5 md5 = new MD5CryptoServiceProvider();
        byte[] result = md5.ComputeHash(fs);
        fs.Close();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < result.Length; ++i)
        {
            sb.Append(result[i].ToString("x2"));
        }
        return sb.ToString();
    }
}
