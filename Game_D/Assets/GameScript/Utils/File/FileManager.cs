using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class FileManager
{
    public static bool WriteToFile(string path , string content)
    {
        if (string.IsNullOrEmpty(path))
        {
            return false;
        }

        var fullPath = Path.Combine(Application.persistentDataPath, path);
        try
        {
            File.WriteAllText(fullPath,content);
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }
    }

    public static bool LoadFromFile(string path ,out string result)
    {
        var fullPath = Path.Combine(Application.persistentDataPath, path);
        if (!File.Exists(fullPath))
        {
            File.WriteAllText(fullPath,"");
        }

        try
        {
            result = File.ReadAllText(fullPath);
            return true;
        }
        catch (Exception e)
        {
            
            Console.WriteLine(e);
            result = "";
            return false;
        }
    }

    public static bool MoveFile(string path , string newPath)
    {
        var path0 = Path.Combine(Application.persistentDataPath, path);
        var path1 = Path.Combine(Application.persistentDataPath, newPath);

        try
        {
            if (File.Exists(path1))
            {
                File.Delete(path1);
            }

            if (!File.Exists(path0))
            {
                return false;
            }
            File.Move(path0,path1);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

}
