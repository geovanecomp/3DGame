using UnityEngine;
using System.Collections;

//Classe quebra galho, provavelmente sera substituida
public class MovimentPlayer : MonoBehaviour {
	private Transform player;
	private float normalSpeed;
	float rotationSpeed;
	
	void Start () {
 		normalSpeed = 50;
		rotationSpeed = 100;
		transform.position = new Vector3 (424.168f, 15f, 158.54f); //seta o jogador na posicao inicial
	}

	void Update () {
		//Movimentara o jogador em funcao da tecla pressionada 
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
}
