using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class hole : MonoBehaviour {

	public bool isTri = false;
	public static int DragCount = 0;
	public bool up = false;
	public Text timerStr;
	public Flowchart flowchart;

	bool firstDrag = false;
	bool alreadyHave = false;
	int timer = 90;
	bool started = true;

	// Use this for initialization
	void Start () {
		initial ();
	}

	void initial(){
		isTri = false;
		DragCount = 0;
		firstDrag = false;
		alreadyHave = false;
		up = false;
		timer = 90;
		started = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (started && firstDrag==true) {
			StartCoroutine ("countDown");
			timerStr.text = timer.ToString()+"秒";
			started = false;
		}
		if (timer == 0) {
			//started == false;
			//firstDrag == false;
			flowchart.SetBooleanVariable ("lose", true);
		}

		
	}

	IEnumerator countDown(){
		if (timer > 0) {
			timer--;
			yield return new WaitForSeconds (1);
			started = true;
		} else {
			//started == false;
			//firstDrag == false;

			flowchart.SendFungusMessage ("lose");

		}
			

	}

	void OnMouseDrag()
	{
		DragCount ++;
		if (DragCount == 1) {
			firstDrag = true;
		}
		//GameObject hint = GameObject.FindWithTag("one");
		float x = Input.mousePosition.x;
		float y = Input.mousePosition.y;
		//float numberX = hint.transform.position.x;
		//float numberY = hint.transform.position.y;


			Vector3 point = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, 1f));
		if (isTri == false) {
			//Debug.Log ("沒有成功");
			transform.position = point;
		
		}
		   
		}

	void OnMouseUp(){
		isTri=false;
		up = true;
	}



}
