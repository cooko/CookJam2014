using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
	public GameObject projectilePrimary;
	public GameObject projectileSecondary;
	public GameObject turretPrimary;
	public GameObject turretSecondary;
	public float fireRatePrimary;
	public float fireRateSecondary;
	public float fireRateTurret;
	protected float cooldownPrimary = 0;
	protected float cooldownSecondary = 0;
	protected float cooldownTurret = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		print(cooldownPrimary);
		if (Input.GetAxis("Fire2") > 0 && cooldownSecondary < 0) {
			Fire(projectileSecondary);
			cooldownSecondary = fireRateSecondary;
		}
		else if (Input.GetButton("Fire1") && cooldownPrimary < 0) {
			Fire(projectilePrimary);
			cooldownPrimary = fireRatePrimary;
		}

		if (cooldownTurret < 0) {
			if (Input.GetButton("Fire3")) {
				Fire (turretPrimary);
			}
			else if (Input.GetAxis("Fire4") > 0) {
				Fire (turretSecondary);
			}
		}

		cooldownPrimary -= 1 * Time.deltaTime;
		cooldownSecondary -= 1 * Time.deltaTime;
		cooldownTurret -= 1 * Time.deltaTime;
	}

	public void Fire(GameObject projectile) {
		Instantiate (projectile, transform.position, transform.rotation);
	}
}
