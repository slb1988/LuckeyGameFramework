using UnityEngine;
using System.Collections;

public class ReadConfigTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(VarsInternal.Get().Value("Config.Version"));
        Debug.Log(VarsInternal.Get().Value("Aurora.Version.Source"));
        Debug.Log(VarsInternal.Get().Value("Localization.Locale"));
        Debug.Log(VarsInternal.Get().Value("Application.Mode"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
