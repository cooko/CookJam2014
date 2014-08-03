using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public float speed;
	public string player;
	float lifeTime;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate() {
		transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
		lifeTime += 1 * Time.deltaTime;
		if (lifeTime > 3){
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Wall"){
			Destroy (gameObject);				
		}
		//if (collider.gameObject.tag == "Level" || (collider.gameObject.tag == "Player" && collider.gameObject.name != player)) {
		//Destroy(gameObject);
		//}
	}
}
