using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("hello");
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Input.GetMouseButton(0))
		{
			RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, 10, 0);
			Debug.Log (hit.collider);
			if (hit.collider)
			{
				Debug.Log ("hit.transform.name");
			}
		}
    }




}
