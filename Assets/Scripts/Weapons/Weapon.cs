﻿using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	public GameObject Projectile;
	public float FireRate;
	public float knockback;
	protected float cooldown;
	protected bool fireable;

	// Use this for initialization
	void Start () {
		fireable = true;
		cooldown = 0;

	}
	
	// Update is called once per frame
	void Update () {
		bool fire = Input.GetButton("Fire1");

		if(fire){
			Fire();
		}
		//if(cooldown > 0){
		//	cooldown -= 1 * Time.deltaTime;
		//}else{
		//	fireable = true;
		//}
	}
	public bool Fire(){
		//if(fireable){
			GameObject projectile = (GameObject) Instantiate (Projectile, transform.position, transform.rotation);
			//Projectile projectile_script = projectile.GetComponent<Projectile>();
			//projectile_script.player = transform.parent.gameObject.name;
			//fireable = false;
			//cooldown = FireRate;
			return true;
		//}else{
		//	return false;
		//}

	}
}
