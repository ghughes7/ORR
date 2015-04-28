using UnityEngine;
using System.Collections;

public class Reticle : MonoBehaviour {

	public Camera cameraFacing;
	private Vector3 originalScale;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		originalScale = transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		float dist;
		if (Physics.Raycast (new Ray (cameraFacing.transform.position, cameraFacing.transform.rotation * Vector3.forward), 
		                     out hit)) {
			dist = hit.distance;
		} else {
			dist = cameraFacing.farClipPlane * 0.95f;
		}

		if (Input.GetKey ("space")) {
			if (hit.collider.name == "selection_screen_1"){
//				print ("success");
				GameObject temp = GameObject.Find("selection_screen_1");
				Renderer rend = temp.GetComponent<Renderer>();
				rend.enabled = false;
			}
		}


		transform.LookAt (cameraFacing.transform.position);
		transform.Rotate (0.0f, 180.0f, 0.0f);
		transform.position = cameraFacing.transform.position + 
			cameraFacing.transform.rotation * Vector3.forward * dist;
		transform.localScale = originalScale * dist;

	}
}
