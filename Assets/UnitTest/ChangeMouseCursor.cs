using UnityEngine;
using System.Collections;

public class ChangeMouseCursor : MonoBehaviour {

    public PegCursor.Mode cursorMode = PegCursor.Mode.UP;

	// Use this for initialization
	void Start () {
        PegCursor.Get().Show();
        PegCursor.Get().SetMode(PegCursor.Mode.UP);
	}
	
	// Update is called once per frame
    void Update()
    {
        PegCursor.Get().SetMode(PegCursor.Mode.UP);
	
	}
}
