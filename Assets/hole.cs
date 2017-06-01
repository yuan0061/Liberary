using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour {
	
	Vector3 point;
	float x;
	float y;
	float z;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}
	void OnMouseDrag()
	{
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;


		point = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 1f));
		gameObject.transform.position = point;


	}
}
