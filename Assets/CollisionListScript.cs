using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionListScript : MonoBehaviour {

	public List<Collider2D> CollisionObjects;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			CollisionObjects.Add (other);
		}
	}

	public void OnTriggerExit2D(Collider2D other){
		CollisionObjects.Remove (other);
	}

}
