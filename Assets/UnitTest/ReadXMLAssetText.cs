using UnityEngine;
using System.Collections;
using System.Xml;

public class ReadXMLAssetText : MonoBehaviour {

    [SerializeField]
    TextAsset txt;

	// Use this for initialization
	void Start () {
        XmlDocument xmlDoc = XmlUtils.LoadXmlDocFromTextAsset(txt);

        int i = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
