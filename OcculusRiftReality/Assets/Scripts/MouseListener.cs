using UnityEngine;
using System.Collections;

public class MouseListener : MonoBehaviour {
	
	Ray ray;
	RaycastHit hit;
	

	void Start()
	{

	}

	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {

			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit))
			{
				if (hit.collider.name == "selection_screen_1")
				{
//					Renderer rend = GetComponent<Renderer>(); 
//					rend.enabled = false;
//					print("sucess");
					GameObject screen1 = GameObject.Find("FirstScreen");
					Canvas canvas = screen1.GetComponent<Canvas>();
					canvas.enabled = true;
	
				}
//				print (hit.collider.name);

			}

		}

//		if (Input.GetMouseButtonDown(0))
//			Debug.Log("Pressed left click.");
//		
//		if (Input.GetMouseButtonDown(1))
//			Debug.Log("Pressed right click.");
//		
//		if (Input.GetMouseButtonDown(2))
//			Debug.Log("Pressed middle click.");
	}
	
}
