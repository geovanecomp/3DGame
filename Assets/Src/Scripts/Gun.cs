using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	int ammoMax;
	int ammoMin;
	int ammo;
	float shootSpeed;
	float shootTime;
	float shootTimeDelay;
	[SerializeField]GameObject bullet; // [SerializeField] e pra poder preencher na engine quem sera
	GameObject bala;
	// Use this for initialization
	void Start () {
		ammoMax = 10;
		ammoMin = 0;
		ammo = 200;
		shootTime = 2;
		shootTimeDelay = 2;
		bala = GameObject.FindGameObjectWithTag("Bullet");
	}
	
	// Update is called once per frame
	void Update () {
		shootTime = shootTime + Time.deltaTime;
		shoot();
	}

	void shoot(){
		if (Input.GetKeyDown (KeyCode.S) && ammo > ammoMin && shootTime > shootTimeDelay) {
			Instantiate (bullet, transform.position, transform.rotation);
			ammo = ammo - 1;
			shootTime = 0;
			//bullet.SetActive(false); Tentar fazer a bala desaparecer dps de um tempo
		}
	}
}
