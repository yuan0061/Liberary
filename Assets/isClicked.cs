﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isClicked : MonoBehaviour {
	bool isClick=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	

		if (Input.GetMouseButtonDown (0)) {
			isClick = true;

		}
	}
}
