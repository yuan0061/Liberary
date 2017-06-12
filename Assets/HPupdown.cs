using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPupdown : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//InvokeRepeating ("HPDrop", 1f, 3f);
	}

	// Update is called once per frame
	void Update () {

	}
	public void HPDrop(float num){

		this.GetComponent<Image> ().fillAmount -= num;

	}
}