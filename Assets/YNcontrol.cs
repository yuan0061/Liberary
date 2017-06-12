using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class YNcontrol : MonoBehaviour {

	public Flowchart flowchart;
	public bookCount book;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (flowchart.GetBooleanVariable ("success") == true) {
			book.AddBook (10);
			flowchart.SetBooleanVariable ("success", false);
		}
	}

	void fungusJudge(){
		bool bool1 = GameObject.Find ("1").GetComponent<winOrLose> ().bool1;
		bool bool2 = GameObject.Find ("2").GetComponent<winOrLose> ().bool2;
		bool bool3 = GameObject.Find ("3").GetComponent<winOrLose> ().bool3;
		bool bool4 = GameObject.Find ("4").GetComponent<winOrLose> ().bool4;
		bool bool5 = GameObject.Find ("5").GetComponent<winOrLose> ().bool5;
		bool bool6 = GameObject.Find ("6").GetComponent<winOrLose> ().bool6;
		bool bool7 = GameObject.Find ("7").GetComponent<winOrLose> ().bool7;
		bool bool8 = GameObject.Find ("8").GetComponent<winOrLose> ().bool8;
		bool bool9 = GameObject.Find ("9").GetComponent<winOrLose> ().bool9;
		bool bool10 = GameObject.Find ("10").GetComponent<winOrLose> ().bool10;
		bool bool11 = GameObject.Find ("11").GetComponent<winOrLose> ().bool11;
		if (bool1 && bool2 && bool3 && bool4 && bool5 && bool6 && bool7 && bool8 && bool9 && bool10 && bool11) {
			flowchart.SetBooleanVariable ("success", true);

		
		} else {
			flowchart.SetBooleanVariable ("success", false);
		}
	}
}
