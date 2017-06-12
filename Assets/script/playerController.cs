using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public Sprite faceR;
    public Sprite faceL;
    SpriteRenderer playerSpriteRenderer;
    // Use this for initialization
    void Start () {
        playerSpriteRenderer = (SpriteRenderer)GetComponent("SpriteRenderer");
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