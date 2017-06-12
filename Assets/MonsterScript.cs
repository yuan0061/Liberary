using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour {

	public float MoveSpeed;
	public GameObject FollowTarget;
	private Rigidbody2D rigidbody;
	public CollisionListScript PlayerSensor;
	public CollisionListScript AttackSensor;
	public HPupdown hp;
    public Flowchart flowchart;
    // Use this for initialization
    void Start () {
		rigidbody = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerSensor.CollisionObjects.Count > 0) {
			FollowTarget = PlayerSensor.CollisionObjects [0].gameObject;
			//Debug.Log ("here!");
		}else{
			FollowTarget = null;
			rigidbody.velocity = Vector2.zero;
		}
		float lookAt = FollowTarget.gameObject.transform.position.x;
		if (FollowTarget.gameObject.transform.position.x <= this.gameObject.transform.position.x) {
			this.gameObject.transform.Translate (-Time.deltaTime * 5f,0,0);
		}else{
			this.gameObject.transform.Translate (Time.deltaTime * 5f,0,0);

		}
		if (AttackSensor.CollisionObjects.Count > 0) {
			hp.HPDrop (0.005f);
            flowchart.ExecuteBlock("beAttacked");
        }

		/*if (PlayerSensor.CollisionObjects.Count != 0) {
			Vector3 lookAt = FollowTarget.gameObject.transform.position;

			this.gameObject.transform.Translate (-lookAt * Time.deltaTime * 0.5f);
		} else {
			rigidbody.velocity = Vector2.zero;
			Debug.Log (rigidbody.velocity);
		}*/

		/*if (FollowTarget != null) {
			Vector3 lookAt = FollowTarget.gameObject.transform.position;
			lookAt.y = this.gameObject.transform.position.y;
			this.transform.LookAt (lookAt);
		}*/

	}
}
