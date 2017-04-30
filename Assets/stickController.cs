using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnColliderEnter2D(Collider collider){
		Debug.Log ("enter");
	}


	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log (collider.transform.position.y);
		if (collider.transform.position.y > this.transform.position.y) {
			Debug.Log ("come from up");
			//collider.transform.TransformVector;
		}
	}
}
