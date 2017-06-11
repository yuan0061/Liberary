using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class transport : MonoBehaviour {
	public GameObject persent;
	public comManager commanager;

	bool isClicked=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(isClicked==true && Input.GetKeyDown(KeyCode.Return)){
			persent.SetActive (true);
			commanager.AddScore (5);
			//Debug.Log ("456");
		}

	}

	void OnTriggerStay2D(Collider2D other){
		//Debug.Log ("123");
		isClicked = true;

	}


}
