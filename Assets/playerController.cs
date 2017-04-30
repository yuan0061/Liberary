using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	float speed = 10;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) { 
			this.transform.position += new Vector3 (0, speed * Time.deltaTime, 0); 
		}
		if (Input.GetKey (KeyCode.S)) { 
			this.transform.position += new Vector3 (0, -speed * Time.deltaTime, 0); 
		}
		if (Input.GetKey (KeyCode.A)) { 
			this.transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0); 
		}
		if (Input.GetKey (KeyCode.D)) { 
			this.transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
		}


	}
}