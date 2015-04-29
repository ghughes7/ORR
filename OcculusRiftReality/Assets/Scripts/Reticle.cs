using UnityEngine;
using System.Collections;


public class Reticle : MonoBehaviour {

	public Camera cameraFacing;
	private Vector3 originalScale;
	public GameObject player;

	//nasty global vars
	public static Vector3 playerPosition = new Vector3(0.495f, 2.672f, -18.0f); //this should only happen once
	public static Quaternion playerRotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
		originalScale = transform.localScale;
		player = GameObject.Find ("OVRPlayerController");
		player.transform.position = playerPosition;
		player.transform.rotation = playerRotation;

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
//				Renderer rend = temp.GetComponent<Renderer>();
//				rend.enabled = false;
				Application.LoadLevel (1);
				Cursor.visible = true;
				//Keep track of player's coords
				playerPosition = player.transform.position;
				playerRotation = player.transform.rotation;
			}
			else if (hit.collider.name == "splineVehicle")
			{
				//Debug.Log(ApplicationModel.splineLevel);
				player.GetComponent<SplineInterpolator>().enabled = true;
				player.GetComponent<SplineController>().enabled = true;
				player.GetComponent<OVRPlayerController>().HmdResetsY = false;
				player.GetComponent<OVRPlayerController>().HmdRotatesY = false;
				this.GetComponent<Renderer>().enabled = false;
//				SplineController spple = new SplineController();
//				spple.Start ();
				print ("got it");
			}
		}


		transform.LookAt (cameraFacing.transform, cameraFacing.transform.position);
		transform.Rotate (new Vector3(0.0f, 180.0f, 0.0f));
		transform.position = cameraFacing.transform.position + 
			cameraFacing.transform.rotation * Vector3.forward * dist;
		transform.localScale = originalScale * dist;

	}
}
