using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class FileUtils
{
    public static bool CreatePersistentDataPath()
    {
        try
        {
            Directory.CreateDirectory(PersistentDataPath);
            return true;
        }
        catch (Exception exception)
        {
            object[] args = new object[] { PersistentDataPath, exception.Message };
//            Blizzard.Log.Write("Error creating persistent data path at '{0}': {1}", args);
            return false;
        }
    }

    public static string GetAssetPath(string fileName)
    {
        return fileName;
    }

    public static void GetLastFolderAndFileFromPath(string path, out string folderName, out string fileName)
    {
        folderName = null;
        fileName = null;
        if (!string.IsNullOrEmpty(path))
        {
            path = path.Replace(@"\", "/");
            int length = path.Length;
            int num2 = path.LastIndexOf("/");
            if (num2 < 0)
            {
                fileName = path;
            }
            else if (length != 1)
            {
                if (num2 == (length - 1))
                {
                    folderName = path.Remove(length - 1, 1);
                }
                else
                {
                    int startIndex = num2 + 1;
                    fileName = path.Substring(startIndex, length - startIndex);
                    if (num2 != 0)
                    {
                        folderName = path.Substring(0, num2);
                        int num4 = folderName.LastIndexOf("/");
                        if (num4 >= 0)
                        {
                            int num5 = num4 + 1;
                            folderName = folderName.Substring(num5, folderName.Length - num5);
                        }
                    }
                }
            }
        }
    }

    public static string GetOnDiskCapitalizationForDir(DirectoryInfo dirInfo)
    {
        DirectoryInfo parent = dirInfo.Parent;
        if (parent == null)
        {
            return dirInfo.Name;
        }
        string name = parent.GetDirectories(dirInfo.Name)[0].Name;
        return System.IO.Path.Combine(GetOnDiskCapitalizationForDir(parent), name);
    }

    public static string GetOnDiskCapitalizationForDir(string dirPath)
    {
        DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
        return GetOnDiskCapitalizationForDir(dirInfo);
    }

    public static string GetOnDiskCapitalizationForFile(FileInfo fileInfo)
    {
        DirectoryInfo directory = fileInfo.Directory;
        string name = directory.GetFiles(fileInfo.Name)[0].Name;
        return System.IO.Path.Combine(GetOnDiskCapitalizationForDir(directory), name);
    }

    public static string GetOnDiskCapitalizationForFile(string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        return GetOnDiskCapitalizationForFile(fileInfo);
    }

    public static IntPtr LoadPlugin(string fileName)
    {
        return IntPtr.Zero;
        //PlatformDependentValue<string> value2 = new PlatformDependentValue<string>(PlatformCategory.OS)
        //{
        //    PC = "Hearthstone_Data/Plugins/{0}",
        //    Mac = "Hearthstone.app/Contents/Plugins/{0}.bundle/Contents/MacOS/{0}",
        //    iOS = string.Empty,
        //    Android = string.Empty
        //};
        //try
        //{
        //    string filename = string.Format((string)value2, fileName);
        //    IntPtr ptr = DLLUtils.LoadLibrary(filename);
        //    if (ptr == IntPtr.Zero)
        //    {
        //        object[] args = new object[] { Directory.GetCurrentDirectory(), filename };
        //        string str2 = Blizzard.Path.combine(args);
        //        Debug.LogError(string.Format("Failed to load plugin from '{0}'", str2));
        //        object[] messageArgs = new object[] { fileName };
        //        Error.AddFatalLoc("GLOBAL_ERROR_ASSET_LOAD_FAILED", messageArgs);
        //    }
        //    return ptr;
        //}
        //catch (Exception exception)
        //{
        //    Debug.LogError(string.Format("FileUtils.LoadPlugin() - Exception occurred. message={0} stackTrace={1}", exception.Message, exception.StackTrace));
        //    return IntPtr.Zero;
        //}
    }

    public static string MakeLocalizedPathFromSourcePath(Locale locale, string path)
    {
        string directoryName = System.IO.Path.GetDirectoryName(path);
        string fileName = System.IO.Path.GetFileName(path);
        int startIndex = directoryName.LastIndexOf("/", StringComparison.OrdinalIgnoreCase);
        if ((startIndex >= 0) && directoryName.Substring(startIndex + 1).Equals(Localization.DEFAULT_LOCALE_NAME))
        {
            directoryName = directoryName.Remove(startIndex);
        }
        return string.Format("{0}/{1}/{2}", directoryName, locale, fileName);
    }

    public static string MakeMetaPathFromSourcePath(string path)
    {
        return string.Format("{0}.meta", path);
    }

    public static string MakeSourceAssetMetaPath(string path)
    {
        return MakeMetaPathFromSourcePath(MakeSourceAssetPath(path));
    }

    public static string MakeSourceAssetPath(DirectoryInfo folder)
    {
        return MakeSourceAssetPath(folder.FullName);
    }

    public static string MakeSourceAssetPath(FileInfo fileInfo)
    {
        return MakeSourceAssetPath(fileInfo.FullName);
    }

    public static string MakeSourceAssetPath(string path)
    {
        string str = path.Replace(@"\", "/");
        int index = str.IndexOf("/Assets", StringComparison.OrdinalIgnoreCase);
        return str.Remove(0, index + 1);
    }

    public static bool ParseConfigFile(string filePath, ConfigFileEntryParseCallback callback)
    {
        return ParseConfigFile(filePath, callback, null);
    }

    public static bool ParseConfigFile(string filePath, ConfigFileEntryParseCallback callback, object userData)
    {
        if (callback == null)
        {
            Debug.LogWarning("FileUtils.ParseConfigFile() - no callback given");
            return false;
        }
        if (!System.IO.File.Exists(filePath))
        {
            Debug.LogWarning(string.Format("FileUtils.ParseConfigFile() - file {0} does not exist", filePath));
            return false;
        }
        int num = 1;
        using (StreamReader reader = System.IO.File.OpenText(filePath))
        {
            string baseKey = string.Empty;
            while (reader.Peek() != -1)
            {
                string str2 = reader.ReadLine().Trim();
                if ((str2.Length >= 1) && (str2[0] != ';'))
                {
                    if (str2[0] == '[')
                    {
                        if (str2[str2.Length - 1] != ']')
                        {
                            Debug.LogWarning(string.Format("FileUtils.ParseConfigFile() - bad key name \"{0}\" on line {1} in file {2}", str2, num, filePath));
                        }
                        else
                        {
                            baseKey = str2.Substring(1, str2.Length - 2);
                        }
                    }
                    else if (!str2.Contains("="))
                    {
                        Debug.LogWarning(string.Format("FileUtils.ParseConfigFile() - bad value pair \"{0}\" on line {1} in file {2}", str2, num, filePath));
                    }
                    else
                    {
                        char[] separator = new char[] { '=' };
                        string[] strArray = str2.Split(separator);
                        string subKey = strArray[0].Trim();
                        string val = strArray[1].Trim();
                        if ((val[0] == '"') && (val[val.Length - 1] == '"'))
                        {
                            val = val.Substring(1, val.Length - 2);
                        }
                        callback(baseKey, subKey, val, userData);
                    }
                }
            }
        }
        return true;
    }

    public static string PersistentDataPath
    {
        get
        {
            string str = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).Replace('\\', '/');
            return string.Format("{0}/Blizzard/Hearthstone", str);
        }
    }

    public delegate void ConfigFileEntryParseCallback(string baseKey, string subKey, string val, object userData);
}
