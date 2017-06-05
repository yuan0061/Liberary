using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hole : MonoBehaviour {
	public bool isTri=false;
	bool alreadyHave=false;
	public bool up=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		
	}
	void OnMouseDrag()
	{
		//GameObject hint = GameObject.FindWithTag("one");
		float x = Input.mousePosition.x;
		float y = Input.mousePosition.y;
		//float numberX = hint.transform.position.x;
		//float numberY = hint.transform.position.y;


			Vector3 point = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 1f));
		if (isTri == false) {
			Debug.Log ("沒有成功");
			transform.position = point;
		
		}
		   
		}

	void OnMouseUp(){
		isTri=false;
		up = true;
	}



}
