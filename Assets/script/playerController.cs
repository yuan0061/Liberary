﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public Sprite faceR;
    public Sprite faceL;
    SpriteRenderer playerSpriteRenderer;
    public bookCount book;
    // Use this for initialization
    void Start () {
        playerSpriteRenderer = (SpriteRenderer)GetComponent("SpriteRenderer");

        int i = book.GetScenceNumber();
        if (i == 1)
        {   
            //printer
            this.transform.position = new Vector3(2,0,0);
        }
        else if (i == 2)
        {   
            //library
            this.transform.position = new Vector3(117, 0, 0);
        }
        else if (i == 3) {
            //home
            this.transform.position = new Vector3(25, 0, 0);

        }
    }

	float speed = 10;
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.W)|| Input.GetKey(KeyCode.Space)|| Input.GetKey(KeyCode.UpArrow)) { 
			this.transform.position += new Vector3 (0, speed * Time.deltaTime, 0); 
		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) { 
			this.transform.position += new Vector3 (0, -speed * Time.deltaTime, 0); 
		}
		if (Input.GetKey (KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow)) { 
			this.transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0);
            playerSpriteRenderer.sprite = faceL;
        }
		if (Input.GetKey (KeyCode.D)|| Input.GetKey(KeyCode.RightArrow)) { 
			this.transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
            playerSpriteRenderer.sprite = faceR;

        }

       

    }
}