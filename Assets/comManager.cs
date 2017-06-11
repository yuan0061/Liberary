using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class comManager : MonoBehaviour {

	public Flowchart flowchart;
	private Text _text;
	private int _currentScore;

	// Use this for initialization
	void Start () {
		_currentScore = flowchart.GetIntegerVariable ("傳播率");
		_text = this.GetComponent<Text> (); 
		_text.text =  _currentScore + "%";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddScore(int score) 
	{ 
		_currentScore += score; 
		_text.text =  _currentScore + "%";  
		flowchart.SetIntegerVariable ("傳播率", _currentScore);
	} 
		
}
