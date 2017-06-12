using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hole : MonoBehaviour {
	public bool isTri=false;
	public static int DragCount=0;
	bool firstDrag=false;
	bool alreadyHave=false;
	public bool up=false;
	public Text timerStr;
	int timer=90;
	bool started = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (started && firstDrag==true) {
			StartCoroutine ("countDown");
			timerStr.text = timer.ToString()+"秒";
			started = false;
		}

		
	}

	IEnumerator countDown(){
		timer--;
		yield return new WaitForSeconds (1);
		started = true;
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
