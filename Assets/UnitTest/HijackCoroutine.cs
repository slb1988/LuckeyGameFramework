using UnityEngine;
using System.Collections;
using System.Linq;
using System;
using System.Collections.Generic;

[RequireComponent(typeof(GUIText))]
public class HijackCoroutine : MonoBehaviour {
    // This will hold the counting up coroutine
    IEnumerator _countUp;
    IEnumerator _countDown;

    IEnumerator _current;

    int value = 0;

	// Use this for initialization
	void Start () {
        _countUp = CountUp();
        _countDown = CountDown();
        StartCoroutine(DoHijack());
	}
	
	// Update is called once per frame
	void Update () {
        guiText.text = value.ToString();
	}

    void OnGUI()
    {
        if (GUILayout.Button("Swith functions"))
        {
            if (_current == _countUp)
                _current = _countDown;
            else
                _current = _countUp;
        }

        GUILayout.Label(value.ToString());
    }

    IEnumerator DoHijack()
    {
        while (true)
        {
            if (_current != null && _current.MoveNext())
            {
                yield return _current.Current;
            }
            else
                yield return null;
        }
    
    }

    IEnumerator CountUp()
    {
        float increment = 0;
        while (true)
        {
            if (Input.GetKey(KeyCode.Q))
                break;
            increment += Time.deltaTime;
            value += Mathf.RoundToInt(increment);
            yield return null;
        }
    }

    IEnumerator CountDown()
    {
        float increment = 0f;
        while (true)
        {
            if (Input.GetKey(KeyCode.Q))
                break;
            increment += Time.deltaTime;
            value -= Mathf.RoundToInt(increment);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
