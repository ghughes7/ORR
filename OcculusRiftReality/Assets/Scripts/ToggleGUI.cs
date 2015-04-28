using UnityEngine;
using System.Collections;

public class ToggleGUI : MonoBehaviour {

	Canvas c;

	// Use this for initialization
	void Start () {
		//starts off not visible
		c = GetComponent<Canvas> ();
		c.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) && c.enabled) {
			c.enabled = false;
	}
}
}
