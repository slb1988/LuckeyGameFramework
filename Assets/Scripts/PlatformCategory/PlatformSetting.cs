using System;
public class PlatformSetting<T>
{
	public T Setting = default(T);
	public bool WasSet;
	public void Set(T val)
	{
		this.Setting = val;
		this.WasSet = true;
	}
	public T Get()
	{
		return this.Setting;
	}
}
