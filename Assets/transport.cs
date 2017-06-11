using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class transport : MonoBehaviour {
	public GameObject persent1;
	public GameObject persent3;
	public GameObject persent5;
	public GameObject g1;
	public GameObject g2;
	public GameObject g3;
	public GameObject b1;
	public GameObject b2;
	public GameObject b3;
	public comManager commanager;
	private float ran;
	private float ran2;

	bool isClicked=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(isClicked==true && Input.GetKeyDown(KeyCode.Return)){
			ran = Random.Range (0f, 1f);
			Debug.Log (ran);
			if (ran < 0.33) {
				persent1.SetActive (true);
				commanager.AddScore (1);
				if (ran < 0.165) {
					g1.SetActive (true);
				} else {
					b1.SetActive (true);
				}
			} else if (ran >= 0.33 && ran <= 0.67) {
				persent3.SetActive (true);
				commanager.AddScore (3);
				if (ran < 0.5) {
					g2.SetActive (true);
				} else {
					b2.SetActive (true);
				}
			} else {
				persent5.SetActive (true);
				commanager.AddScore (5);
				if (ran < 0.83) {
					g3.SetActive (true);
				} else {
					b3.SetActive (true);
				}
			}
			Invoke ("noActive", 1);
			Invoke ("active", 1);

			//Debug.Log ("456");
		}

	}

	void OnTriggerStay2D(Collider2D other){
		//Debug.Log ("123");
		if(other.tag == "Player"){
			isClicked = true;
		}


	}
	void noActive(){
		this.gameObject.SetActive (false);
	}

	void active(){
		ran2 = Random.Range (30f, 100f);
		this.gameObject.transform.position = new Vector3(ran2, this.gameObject.transform.position.y, 0);
		this.gameObject.SetActive (true);
		isClicked=false;
		persent1.SetActive (false);
		persent3.SetActive (false);
		persent5.SetActive (false);
		g1.SetActive (false);
		g2.SetActive (false);
		g3.SetActive (false);
		b1.SetActive (false);
		b2.SetActive (false);
		b3.SetActive (false);
	}

}
