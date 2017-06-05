using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winOrLose : MonoBehaviour {
	//GameObject[] gb = new GameObject[11];
	// Use this for initialization
	public bool already=false;
    bool isTri=false;
	void Start () {
		
	}
	
	// Update is called once per frame

    void Update () {
		
	}


	void OnTriggerStay2D(Collider2D other){
		//Debug.Log("撞到了");
		//string name = name;

		already=true;
		float wordX = other.transform.position.x;
		float wordY = other.transform.position.y;
		float wordZ = other.transform.position.z;

		float numberX = transform.position.x;
		float numberY = transform.position.y;
		float numberZ = transform.position.z;
		bool up = other.gameObject.GetComponent<hole> ().up;
		if (up==true && wordX > numberX - 0.3 && wordX < numberX + 0.3 && wordY > numberY - 0.3 && wordY < numberY + 0.3) {
			other.gameObject.GetComponent<hole> ().isTri=true;
		    other.transform.position = new Vector3 (numberX,numberY,numberZ);


		}
	}	





}
