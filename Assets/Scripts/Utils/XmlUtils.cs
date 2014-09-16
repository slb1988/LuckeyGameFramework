using System;
using System.IO;
using System.Text;
using System.Xml;
using UnityEngine;
public class XmlUtils
{
	public static string EscapeXPathSearchString(string search)
	{
		char[] anyOf = new char[]
		{
			'\'',
			'"'
		};
		StringBuilder stringBuilder = new StringBuilder();
		int num = search.IndexOfAny(anyOf);
		if (num == -1)
		{
			stringBuilder.Append('\'');
			stringBuilder.Append(search);
			stringBuilder.Append('\'');
		}
		else
		{
			stringBuilder.Append("concat(");
			int num2 = 0;
			while (num != -1)
			{
				stringBuilder.Append('\'');
				stringBuilder.Append(search, num2, num - num2);
				stringBuilder.Append("', ");
				string value;
				if (search[num] == '\'')
				{
					value = "\"'\", ";
				}
				else
				{
					value = "'\"', ";
				}
				stringBuilder.Append(value);
				num2 = num + 1;
				num = search.IndexOfAny(anyOf, num + 1);
			}
			stringBuilder.Append('\'');
			stringBuilder.Append(search, num2, search.Length - num2);
			stringBuilder.Append("')");
		}
		return stringBuilder.ToString();
	}
	public static XmlDocument LoadXmlDocFromTextAsset(TextAsset asset)
	{
		XmlDocument xmlDocument = new XmlDocument();
		StringReader stringReader = new StringReader(asset.text);
		xmlDocument.LoadXml(stringReader.ReadToEnd());
		return xmlDocument;
	}
	public static void RemoveAllChildNodes(XmlNode node)
	{
		if (node == null)
		{
			return;
		}
		while (node.HasChildNodes)
		{
			node.RemoveChild(node.FirstChild);
		}
	}
}
