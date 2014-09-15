using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
public class Localization
{
	public const Locale DEFAULT_LOCALE = Locale.enUS;
	public static readonly string DEFAULT_LOCALE_NAME = Locale.enUS.ToString();
	public static readonly Dictionary<Locale, Locale[]> LOAD_ORDERS;
	private static Localization s_instance;
	private Locale m_locale;
	private CultureInfo m_cultureInfo;
	public static readonly PlatformDependentValue<bool> LOCALE_FROM_OPTIONS;
	static Localization()
	{
		// Note: this type is marked as 'beforefieldinit'.
		Dictionary<Locale, Locale[]> dictionary = new Dictionary<Locale, Locale[]>();
		dictionary.Add(Locale.enUS, new Locale[1]);
		Dictionary<Locale, Locale[]> arg_2F_0 = dictionary;
		Locale arg_2F_1 = Locale.enGB;
		Locale[] expr_2B = new Locale[2];
		expr_2B[0] = Locale.enGB;
		arg_2F_0.Add(arg_2F_1, expr_2B);
		dictionary.Add(Locale.frFR, new Locale[]
		{
			Locale.frFR
		});
		dictionary.Add(Locale.deDE, new Locale[]
		{
			Locale.deDE
		});
		dictionary.Add(Locale.koKR, new Locale[]
		{
			Locale.koKR
		});
		dictionary.Add(Locale.esES, new Locale[]
		{
			Locale.esES
		});
		dictionary.Add(Locale.esMX, new Locale[]
		{
			Locale.esMX
		});
		dictionary.Add(Locale.ruRU, new Locale[]
		{
			Locale.ruRU
		});
		dictionary.Add(Locale.zhTW, new Locale[]
		{
			Locale.zhTW
		});
		dictionary.Add(Locale.zhCN, new Locale[]
		{
			Locale.zhCN
		});
		dictionary.Add(Locale.itIT, new Locale[]
		{
			Locale.itIT
		});
		dictionary.Add(Locale.ptBR, new Locale[]
		{
			Locale.ptBR
		});
		dictionary.Add(Locale.plPL, new Locale[]
		{
			Locale.plPL
		});
		dictionary.Add(Locale.ptPT, new Locale[]
		{
			Locale.ptPT,
			Locale.ptBR
		});
		Localization.LOAD_ORDERS = dictionary;
		Localization.s_instance = new Localization();
		Localization.LOCALE_FROM_OPTIONS = new PlatformDependentValue<bool>(PlatformCategory.OS)
		{
			iOS = true,
			Android = true,
			PC = false,
			Mac = false
		};
	}
	public static void Initialize()
	{
		string text = null;
		if (Localization.LOCALE_FROM_OPTIONS)
		{
			int @int = Options.Get().GetInt(Option.LOCALE);
			if (@int >= 0)
			{
				text = ((Locale)@int).ToString();
			}
		}
		if (text == null)
		{
			text = Vars.Key("Localization.Locale").GetStr(Localization.DEFAULT_LOCALE_NAME);
		}
		if (!Localization.SetLocaleName(text))
		{
			Localization.SetLocale(Locale.enUS);
		}
	}
	public static Locale GetLocale()
	{
		return Localization.s_instance.m_locale;
	}
	public static void SetLocale(Locale locale)
	{
		Localization.s_instance.SetPegLocale(locale);
	}
	public static string GetLocaleName()
	{
		return Localization.s_instance.m_locale.ToString();
	}
	public static bool SetLocaleName(string localeName)
	{
		if (!Localization.IsValidLocaleName(localeName))
		{
			return false;
		}
		Localization.s_instance.SetPegLocaleName(localeName);
		return true;
	}
	public static Locale[] GetLoadOrder()
	{
		return Localization.LOAD_ORDERS[Localization.s_instance.m_locale];
	}
	public static CultureInfo GetCultureInfo()
	{
		return Localization.s_instance.m_cultureInfo;
	}
	public static bool IsValidLocaleName(string localeName)
	{
		return Enum.IsDefined(typeof(Locale), localeName);
	}
	public static bool IsForeignLocaleName(string localeName)
	{
		Locale locale;
		try
		{
			locale = (Locale)((int)Enum.Parse(typeof(Locale), localeName));
		}
		catch (Exception)
		{
			return false;
		}
		return locale != Locale.enUS;
	}
	public static List<Locale> GetForeignLocales()
	{
		List<Locale> list = new List<Locale>();
		IEnumerator enumerator = Enum.GetValues(typeof(Locale)).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Locale locale = (Locale)((int)enumerator.Current);
				if (locale != Locale.enUS)
				{
					list.Add(locale);
				}
			}
		}
		finally
		{
			IDisposable disposable = enumerator as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
		return list;
	}
	public static string FormatCurrency(Locale locale, string format, params object[] args)
	{
		string name = Localization.ConvertLocaleToDotNet(locale);
		CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture(name);
		string text = string.Format(cultureInfo, format, args);
		if (locale == Locale.ruRU)
		{
			text = text.Replace(cultureInfo.NumberFormat.CurrencySymbol, string.Format(" {0}", cultureInfo.NumberFormat.CurrencySymbol));
		}
		else
		{
			if (locale == Locale.koKR)
			{
				text = text.Replace(cultureInfo.NumberFormat.CurrencySymbol, "B");
			}
		}
		return text;
	}
	public static string ConvertLocaleToDotNet(Locale locale)
	{
		string localeName = locale.ToString();
		return Localization.ConvertLocaleToDotNet(localeName);
	}
	public static string ConvertLocaleToDotNet(string localeName)
	{
		string arg = localeName.Substring(0, 2);
		string arg2 = localeName.Substring(2, 2).ToUpper();
		return string.Format("{0}-{1}", arg, arg2);
	}
	private void SetPegLocale(Locale locale)
	{
		string pegLocaleName = locale.ToString();
		this.SetPegLocaleName(pegLocaleName);
	}
	private void SetPegLocaleName(string localeName)
	{
		this.m_locale = (Locale)((int)Enum.Parse(typeof(Locale), localeName));
		string name = Localization.ConvertLocaleToDotNet(this.m_locale);
		this.m_cultureInfo = CultureInfo.CreateSpecificCulture(name);
	}
}
