using UnityEngine;
using System.Collections;

public class MoviePlayerTest : MonoBehaviour {

    // 电影纹理
    public MovieTexture movTexture;

	// Use this for initialization
	void Start () {
        //renderer.material.mainTexture = movTexture;

        //movTexture.loop = false;
        //movTexture.Play();
	}

    void OnGUI()
    {

        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), movTexture, ScaleMode.StretchToFill);
        if (GUILayout.Button("播放"))
        {
            if (!movTexture.isPlaying)
            {
                movTexture.Play();
            }
        }
        if (GUILayout.Button("暂停播放"))
        {
            movTexture.Pause();
        }
        if (GUILayout.Button("停止播放"))
        {
            movTexture.Stop();
        }

        //if (GUI.Button(new Rect(20,10,200,50), "Play ControlMode CancelOnTouch"))
        //{
        //}
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
