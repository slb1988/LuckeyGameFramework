using System;
using System.Collections.Generic;
using System.IO;

using UnityEngine;

internal class VarsInternal
{
	private static string s_clientConfig = "client.config";
	private Dictionary<string, string> s_vars = new Dictionary<string, string>();
	private static VarsInternal s_instance = new VarsInternal();
	private VarsInternal()
    {
		if (!FileUtils.ParseConfigFile(VarsInternal.s_clientConfig, new FileUtils.ConfigFileEntryParseCallback(this.OnConfigFileEntryParsed)))
		{
            // if the file is not exist, create it.
			File.OpenWrite(VarsInternal.s_clientConfig);
		}
	}
	public static VarsInternal Get()
	{
		return VarsInternal.s_instance;
	}
	public bool Contains(string key)
	{
		return this.s_vars.ContainsKey(key);
	}
	public string Value(string key)
	{
		return this.s_vars[key];
	}
	private void OnConfigFileEntryParsed(string baseKey, string subKey, string val, object userData)
	{
		string key = string.Format("{0}.{1}", baseKey, subKey);
		this.s_vars[key] = val;
	}
}
