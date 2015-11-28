using UnityEngine;
using System.Collections;

public class IAEnemy : MonoBehaviour {
	private Transform player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Lerpz").transform;
	}
	
	// Update is called once per frame
	void Update () {
		huntPlayer ();
	}
	void huntPlayer(){
		float distanceToPlayer = Vector3.Distance (transform.position, player.position);
		if (distanceToPlayer < 300 && distanceToPlayer > 5) {
			Vector3 Direction = (player.position - transform.position).normalized;
			transform.position += Direction * Time.deltaTime * 50;
			Quaternion newRotationo = Quaternion.LookRotation (Direction);
			transform.rotation = newRotationo;
		}
		else{
			return;
		}
	}

	void OnCollisionEnter (Collision collision){
		if(collision.gameObject.tag == "Lerpz"){
			//Destroy(GameObject.FindGameObjectWithTag("Lerpz")); //PARA DESTRUIR LERPZ
			return;
		}
		if (collision.gameObject.tag == "Bullet") {
			Destroy(gameObject);
			Destroy(GameObject.FindGameObjectWithTag("Bullet")); //PARA DESTRUIR A BALA
		}
	}
}
