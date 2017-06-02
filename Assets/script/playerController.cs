using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public float forceValue;
    public float maxSpeed;
    public float decreasingSpeed;

    public JumpSensor JumpSensor;
    public float JumpSpeed;


    private Rigidbody2D rigidbody2D = null;
    // Use this for initialization
    void Start () {
        rigidbody2D = this.GetComponent<Rigidbody2D>();
    }

	float speed = 10;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) { 
			this.transform.position += new Vector3 (0, speed * Time.deltaTime, 0); 
		}
		if (Input.GetKey (KeyCode.S)) { 
			this.transform.position += new Vector3 (0, -speed * Time.deltaTime, 0); 
		}
		if (Input.GetKey (KeyCode.A)) { 
			this.transform.position += new Vector3 (-speed * Time.deltaTime, 0, 0); 
		}
		if (Input.GetKey (KeyCode.D)) { 
			this.transform.position += new Vector3 (speed * Time.deltaTime, 0, 0);
		}

        Vector2 force = Vector2.zero;

        if (Input.GetKey(KeyCode.Space) && JumpSensor.IsCanJump())
        {               
                rigidbody2D.velocity = Vector3.up * JumpSpeed;
        }
        

        //add other walking way
        if (Input.GetKey(KeyCode.RightArrow)|| Input.GetKey(KeyCode.LeftArrow))
        {
            
            if (Input.GetKey(KeyCode.RightArrow))
            {
                force += new Vector2(forceValue, 0);
                gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                force += new Vector2(-forceValue, 0);
                gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            if (force != Vector2.zero)
            {
                rigidbody2D.AddForce(force);
                float speed = rigidbody2D.velocity.magnitude;
                if (speed > maxSpeed)
                {
                    speed = maxSpeed;
                }
                rigidbody2D.velocity = rigidbody2D.velocity.normalized * speed;
            }
            else
            {
                float speed = rigidbody2D.velocity.magnitude;
                speed -= decreasingSpeed * Time.deltaTime;
                if (speed < 0)
                {
                    speed = 0;
                }
                rigidbody2D.velocity = rigidbody2D.velocity.normalized * speed;
            }

        }

    }
}