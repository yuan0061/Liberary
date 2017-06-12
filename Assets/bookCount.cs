using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bookCount : MonoBehaviour {

	private Text _text;
	public static int bookcount = 0;

	// Use this for initialization
	void Start () {
		_text = this.GetComponent<Text> ();
		_text.text = "X" + bookcount;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddBook(int count){
		bookcount += count;
		_text.text = "X" + bookcount;
	}
}
