using UnityEngine;
using System.Collections;
using System;

public class TestCoroutine : MonoBehaviour {

    private bool isStartCall = false;
    private bool isUpdateCall = false;
    private bool isLateUpdateCall = false;

	// Use this for initialization
	void Start () {
        if (!isStartCall)
        {
            Debug.Log("Start Call Begin.");
            StartCoroutine(StartCountine());
            Debug.Log("Start Call End");
            isStartCall = true;
        }
	}

    IEnumerator StartCountine()
    {
        Debug.Log("This is Start Coroutine");
        yield return null;// new WaitForSeconds(1);
        Debug.Log("This is Start Coroutine Call After.");
    }
	
	// Update is called once per frame
	void Update () {
        if (!isUpdateCall)
        {
            Debug.Log("Update Call Begin.");
            StartCoroutine(UpdateCoutine());
            Debug.Log("Update Call End");
            isUpdateCall = true;

            //this.enabled = false;
            this.gameObject.SetActive(false);
        }
	}

    IEnumerator UpdateCoutine()
    {
        Debug.Log("This is Update Coroutine Call Before");
        yield return null;// new WaitForSeconds(1);
        Debug.Log("This is Update Coroutine Call After");
    }

    void LateUpdate()
    {
        if (!isLateUpdateCall)
        {
            Debug.Log("LateUpdate Call Begin");
            StartCoroutine(LateCountine());
            Debug.Log("LateUpdate Call End");
            isLateUpdateCall = true;
        }
    }

    IEnumerator LateCountine()
    {
        Debug.Log("This is Late Coroutine Call Before");
        yield return null;// new WaitForSeconds(1);
        Debug.Log("This is Late Coroutine Call After");
    }
}
