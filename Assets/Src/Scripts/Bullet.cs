using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	float bulletSpeed;
//	[SerializeField]AudioSource shootSound; //Tentativa de fazer o som tocar ao atirar

	// Use this for initialization
	void Start () {
		bulletSpeed = 50;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-bulletSpeed * Time.deltaTime, 0, 0);
//		shootSound.Play ();
	}

}
