using UnityEngine;
using System;

public class Player : MonoBehaviour {
	Quaternion initRotation;
	public Level level;
	public int a;

	// Use this for initialization
	void Start () {
		initRotation = transform.rotation;
	}

	// Update is called once per frame
	void Update () {
	}
	// Fixed Update is called once per frame
	// Used for better player movement/control
	void FixedUpdate() {
		Movement();
		Rotation();
		Vector3 pos = transform.position;
		Tile tile = level.getTile(pos.x,pos.y);
		if(tile.state != 1){
			tile.state = 1;
		}
		//print(tile);

    }
    /*
    ** Movement()
    ** Horizontal movement control. Moves the player every update based on the control stick
    */
    void Movement() {
		float horizontal = Input.GetAxis("LH");
		float vertical = Input.GetAxis("LV");

		// Horizontal movement
		transform.Translate(Vector3.right * (Math.Abs(horizontal)/8)*Math.Sign(horizontal), Space.World);
		// Vertical movement
		transform.Translate(Vector3.up * (Math.Abs(vertical)/8)*Math.Sign(vertical), Space.World);
    }
    /*
    ** Rotation()
    ** Rotation control. Rotates the player based on the right control stick.
    ** Rotation is in respect to the initial rotation of the object at creation.
    */
    void Rotation(){
		float horizontal = Input.GetAxis("RH");
		float vertical = Input.GetAxis("RV");
		float angle = Mathf.Atan2(vertical, horizontal) * Mathf.Rad2Deg;

		// Rotation is reset to the initial rotation
		transform.rotation = initRotation;
		// Object is rotated into place
		transform.Rotate(0,0,angle);

    }
}
