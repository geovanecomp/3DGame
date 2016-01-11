using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	float bulletSpeed;
	int damage; //Dano dado pela bala, mais para frente poderiamos ter municao de fogo, por exemplo, a qual aumentaria do dano
//	[SerializeField]AudioSource shootSound; //Tentativa de fazer o som tocar ao atirar

	// Use this for initialization
	void Start () {
		bulletSpeed = 50;
		damage = 100;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-bulletSpeed * Time.deltaTime, 0, 0);
//		shootSound.Play ();
	}

	public void setDamage(int damage){
		this.damage = damage;
	}

	public int getDamage(){
		return damage;
	}

}
