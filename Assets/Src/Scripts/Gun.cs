using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {
	int ammoMax;
	int ammoMin;
	int ammo;
	float shootSpeed;
	float shootTime;
	float shootTimeDelay;
	[SerializeField]GameObject bullet; // [SerializeField] e pra poder preencher na engine quem sera "bullet"
	// Use this for initialization
	void Start () {
		//Atributos criados para caso tenha municao no mapa e etc
		ammoMax = 10;
		ammoMin = 0;
		ammo = 200;
		shootTime = 2;
		shootTimeDelay = 1;
	}
	
	// Update is called once per frame
	void Update () {
		shootTime = shootTime + Time.deltaTime;
		shoot();
	}

	void shoot(){
		if (Input.GetKeyDown (KeyCode.F) && ammo > ammoMin && shootTime > shootTimeDelay) {//So atira ao pressionar F e se as balas nao acabaram
			Instantiate (bullet, transform.position, transform.rotation);
			ammo = ammo - 1;
			shootTime = 0;
			//bullet.SetActive(false);//Seria legal destruir as balas dps de um tempo
		}
	}
}
