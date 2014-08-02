using UnityEngine;
using System;

public class player : MonoBehaviour {
	Quaternion initRotation;

	// Use this for initialization
	void Start () {
		initRotation = transform.rotation;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void FixedUpdate() {
		Movement();
		Rotation();
    }
    void Movement() {
		float horizontal = Input.GetAxis("LH");
		float vertical = Input.GetAxis("LV");

		// Horizontal movement
		transform.Translate(Vector3.right * (Math.Abs(horizontal)/8)*Math.Sign(horizontal), Space.World);
		// Vertical movement
		transform.Translate(Vector3.up * (Math.Abs(vertical)/8)*Math.Sign(vertical), Space.World);
    }
    void Rotation(){
		float horizontal = Input.GetAxis("RH");
		float vertical = Input.GetAxis("RV");
		float angle = Mathf.Atan2(vertical, horizontal) * Mathf.Rad2Deg;

		transform.rotation = initRotation;
		transform.Rotate(0,0,angle);

    }
}
