using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winOrLose : MonoBehaviour {
	//GameObject[] gb = new GameObject[11];

	public bool bool1 = false;
	public bool bool2 = false;
	public bool bool3 = false;
	public bool bool4 = false;
	public bool bool5 = false;
	public bool bool6 = false;
	public bool bool7 = false;
	public bool bool8 = false;
	public bool bool9 = false;
	public bool bool10 = false;
	public bool bool11 = false;
    bool isTri = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame

    void Update () {
		
	}


	void OnTriggerStay2D(Collider2D other){
		//Debug.Log("撞到了");
		//string name = name;


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
			if (other.name == "追") {
				bool1 = true;
			}

			if (other.name == "求") {
				bool2 = true;
			}
		
			if (other.name == "科") {
				bool3 = true;
			}

			if (other.name == "學") {
				bool4 = true;
			}

			if (other.name == "需") {
				bool5 = true;
			}

			if (other.name == "要") {
				bool6 = true;
			}

			if (other.name == "特") {
				bool7 = true;
			}

			if (other.name == "殊") {
				bool8 = true;
			}
			if (other.name == "的") {
				bool9 = true;
			}

			if (other.name == "勇") {
				bool10 = true;
			}

			if (other.name == "敢") {
				bool11 = true;
			}



		}
	}	





}
