using UnityEngine;
using System.Collections;

public class MovimentPlayer : MonoBehaviour {
	private Transform player;
	private float normalSpeed;
	float rotationSpeed;
	// Use this for initialization
	void Start () {
		//player = (CharacterController)GetComponent (typeof()
		normalSpeed = 50;
		rotationSpeed = 100;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, 0, Time.deltaTime * normalSpeed);
		} 
		else if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate(0, 0, -Time.deltaTime * normalSpeed);
		}

		if (Input.GetKey(KeyCode.RightArrow)){
			transform.Rotate (0, Time.deltaTime * rotationSpeed, 0);
		}
		else if (Input.GetKey(KeyCode.LeftArrow)){
			transform.Rotate (0, -Time.deltaTime * rotationSpeed, 0);
		}
		//player.Translate (Time.deltaTime, 0, 0);

	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Coin")) {
			other.gameObject.SetActive(false);
		}
	}
	//SOLUCAO TEMPORARIA PARA PEGAR MOEDAS
	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.tag == "Coin") {
			Destroy(GameObject.FindGameObjectWithTag("Coin")); //PARA DESTRUIR A BALA
			//GameObject.FindGameObjectWithTag("Coin").SetActive(false);
		}
	}
}
