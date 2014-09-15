using System;
using UnityEngine;
public class PlatformDependentValue<T>
{
	private bool resolved;
	private T result;
	private PlatformCategory type;
	private T defaultValue;
	private PlatformSetting<T> PCSetting = new PlatformSetting<T>();
	private PlatformSetting<T> MacSetting = new PlatformSetting<T>();
	private PlatformSetting<T> iOSSetting = new PlatformSetting<T>();
	private PlatformSetting<T> AndroidSetting = new PlatformSetting<T>();
	private PlatformSetting<T> TabletSetting = new PlatformSetting<T>();
	private PlatformSetting<T> MiniTabletSetting = new PlatformSetting<T>();
	private PlatformSetting<T> PhoneSetting = new PlatformSetting<T>();
	private PlatformSetting<T> MouseSetting = new PlatformSetting<T>();
	private PlatformSetting<T> TouchSetting = new PlatformSetting<T>();
	private PlatformSetting<T> LowMemorySetting = new PlatformSetting<T>();
	private PlatformSetting<T> MediumMemorySetting = new PlatformSetting<T>();
	private PlatformSetting<T> HighMemorySetting = new PlatformSetting<T>();
	private PlatformSetting<T> NormalScreenDensitySetting = new PlatformSetting<T>();
	private PlatformSetting<T> HighScreenDensitySetting = new PlatformSetting<T>();
	public T PC
	{
		get
		{
			return this.PCSetting.Get();
		}
		set
		{
			this.PCSetting.Set(value);
		}
	}
	public T Mac
	{
		get
		{
			return this.MacSetting.Get();
		}
		set
		{
			this.MacSetting.Set(value);
		}
	}
	public T iOS
	{
		get
		{
			return this.iOSSetting.Get();
		}
		set
		{
			this.iOSSetting.Set(value);
		}
	}
	public T Android
	{
		get
		{
			return this.AndroidSetting.Get();
		}
		set
		{
			this.AndroidSetting.Set(value);
		}
	}
	public T Tablet
	{
		get
		{
			return this.TabletSetting.Get();
		}
		set
		{
			this.TabletSetting.Set(value);
		}
	}
	public T MiniTablet
	{
		get
		{
			return this.MiniTabletSetting.Get();
		}
		set
		{
			this.MiniTabletSetting.Set(value);
		}
	}
	public T Phone
	{
		get
		{
			return this.PhoneSetting.Get();
		}
		set
		{
			this.PhoneSetting.Set(value);
		}
	}
	public T Mouse
	{
		get
		{
			return this.MouseSetting.Get();
		}
		set
		{
			this.MouseSetting.Set(value);
		}
	}
	public T Touch
	{
		get
		{
			return this.TouchSetting.Get();
		}
		set
		{
			this.TouchSetting.Set(value);
		}
	}
	public T LowMemory
	{
		get
		{
			return this.LowMemorySetting.Get();
		}
		set
		{
			this.LowMemorySetting.Set(value);
		}
	}
	public T MediumMemory
	{
		get
		{
			return this.MediumMemorySetting.Get();
		}
		set
		{
			this.MediumMemorySetting.Set(value);
		}
	}
	public T HighMemory
	{
		get
		{
			return this.HighMemorySetting.Get();
		}
		set
		{
			this.HighMemorySetting.Set(value);
		}
	}
	public T NormalScreenDensity
	{
		get
		{
			return this.NormalScreenDensitySetting.Get();
		}
		set
		{
			this.NormalScreenDensitySetting.Set(value);
		}
	}
	public T HighScreenDensity
	{
		get
		{
			return this.HighScreenDensitySetting.Get();
		}
		set
		{
			this.HighScreenDensitySetting.Set(value);
		}
	}
	private T Value
	{
		get
		{
			if (this.resolved)
			{
				return this.result;
			}
            //switch (this.type)
            //{
            //case PlatformCategory.OS:
            //    this.result = this.GetOSSetting(PlatformSettings.OS);
            //    break;
            //case PlatformCategory.Screen:
            //    this.result = this.GetScreenSetting(PlatformSettings.Screen);
            //    break;
            //case PlatformCategory.Memory:
            //    this.result = this.GetMemorySetting(PlatformSettings.Memory);
            //    break;
            //case PlatformCategory.Input:
            //    this.result = this.GetInputSetting(PlatformSettings.Input);
            //    break;
            //}
			this.resolved = true;
			return this.result;
		}
	}
	public PlatformDependentValue(PlatformCategory t)
	{
		this.type = t;
	}
	public void Reset()
	{
		this.resolved = false;
	}
	private T GetOSSetting(OSCategory os)
	{
		switch (os)
		{
		case OSCategory.PC:
			if (this.PCSetting.WasSet)
			{
				return this.PC;
			}
			break;
		case OSCategory.Mac:
			return (!this.MacSetting.WasSet) ? this.GetOSSetting(OSCategory.PC) : this.Mac;
		case OSCategory.iOS:
			return (!this.iOSSetting.WasSet) ? this.GetOSSetting(OSCategory.PC) : this.iOS;
		case OSCategory.Android:
			return (!this.AndroidSetting.WasSet) ? this.GetOSSetting(OSCategory.PC) : this.Android;
		}
		Debug.LogError("Could not find OS dependent value");
		return default(T);
	}
	private T GetScreenSetting(ScreenCategory screen)
	{
		switch (screen)
		{
		case ScreenCategory.PC:
			if (this.PCSetting.WasSet)
			{
				return this.PC;
			}
			break;
		case ScreenCategory.Tablet:
			return (!this.TabletSetting.WasSet) ? this.GetScreenSetting(ScreenCategory.PC) : this.Tablet;
		case ScreenCategory.MiniTablet:
			return (!this.MiniTabletSetting.WasSet) ? this.GetScreenSetting(ScreenCategory.Tablet) : this.MiniTablet;
		case ScreenCategory.Phone:
			return (!this.PhoneSetting.WasSet) ? this.GetScreenSetting(ScreenCategory.Tablet) : this.Phone;
		}
		Debug.LogError("Could not find screen dependent value");
		return default(T);
	}
	private T GetMemorySetting(MemoryCategory memory)
	{
		switch (memory)
		{
		case MemoryCategory.Low:
			if (this.LowMemorySetting.WasSet)
			{
				return this.LowMemory;
			}
			break;
		case MemoryCategory.Medium:
			return (!this.MediumMemorySetting.WasSet) ? this.GetMemorySetting(MemoryCategory.Low) : this.MediumMemory;
		case MemoryCategory.High:
			return (!this.HighMemorySetting.WasSet) ? this.GetMemorySetting(MemoryCategory.Medium) : this.HighMemory;
		}
		Debug.LogError("Could not find memory dependent value");
		return default(T);
	}
	private T GetInputSetting(InputCategory input)
	{
		if (input != InputCategory.Mouse)
		{
			if (input == InputCategory.Touch)
			{
				return (!this.TouchSetting.WasSet) ? this.GetInputSetting(InputCategory.Mouse) : this.Touch;
			}
		}
		else
		{
			if (this.MouseSetting.WasSet)
			{
				return this.Mouse;
			}
		}
		Debug.LogError("Could not find input dependent value");
		return default(T);
	}
	private T GetScreenDensitySetting(ScreenDensityCategory input)
	{
		if (input != ScreenDensityCategory.Normal)
		{
			if (input == ScreenDensityCategory.High)
			{
				return (!this.HighScreenDensitySetting.WasSet) ? this.GetScreenDensitySetting(ScreenDensityCategory.Normal) : this.HighScreenDensity;
			}
		}
		else
		{
			if (this.NormalScreenDensitySetting.WasSet)
			{
				return this.NormalScreenDensity;
			}
		}
		Debug.LogError("Could not find screen density dependent value");
		return default(T);
	}
	public static implicit operator T(PlatformDependentValue<T> val)
	{
		return val.Value;
	}
}
