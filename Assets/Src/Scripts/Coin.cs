using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	private int points = 100;
	private Player playerObject;
	// Use this for initialization
	void Start () {
		playerObject = (Player)GameObject.FindGameObjectWithTag("Player").GetComponent(typeof(Player));
	}

	// Update is called once per frame
	void Update () {
		//Gira a moeda
		transform.Rotate(new Vector3(0, 30, 0));
	}

	public int getPoints(){
		return points;
	}

	void OnTriggerEnter(Collider other){ //Se estiver na area de "coleta", a moeda eh destruida e os pontos adicionados ao jogador
		if (other.gameObject.CompareTag ("Player")) {
			playerObject.increasePoints(points);
			Destroy(gameObject);			
		}
	}
}
