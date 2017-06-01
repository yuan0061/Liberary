using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineScript : MonoBehaviour {

	public LineRenderer line;


	// Use this for initialization
	void Start () {
		LineSetup ();
	}
	
	// Update is called once per frame
	void Update () {
		LineUpdate ();
	}

	void LineSetup(){
		line.SetPosition (0, line.transform.position);
		line.widthMultiplier = 0.05f;
		line.sortingOrder = 1;
	}

	void LineUpdate(){
		/*Vector2 catapultToProjectile = transform.position - line.transform.position;
		leftCatapultToProjectile.direction = catapultToProjectile;
		Vector3 holdPoint = leftCatapultToProjectile.GetPoint (catapultToProjectile.magnitude);
		catapultLineFront.SetPosition (1, holdPoint);
		catapultLineBack.SetPosition (1, holdPoint);*/

		line.SetPosition (1, transform.position);
	}
}
