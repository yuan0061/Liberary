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
		GameObject hint = GameObject.FindWithTag("one");
		float x = transform.position.x;
		float y = transform.position.y;
		float numberX = hint.transform.position.x;
		float numberY = hint.transform.position.y;

		if (x > numberX - 0.5 & x < numberX + 0.5 & y > numberY - 0.5 & y < numberY + 0.5) {
				
			transform.position = hint.transform.position;
		}
		else{
			point = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 1f));
			gameObject.transform.position = point;
		}


	}
}
