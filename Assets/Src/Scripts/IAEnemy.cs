using UnityEngine;
using System.Collections;

public class IAEnemy : MonoBehaviour {
	private Transform player;
	private Player playerObject;
	private int speed;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").transform;
		playerObject = (Player)GameObject.FindGameObjectWithTag("Player").GetComponent(typeof(Player));
		speed = 50;
	}
	
	// Update is called once per frame
	void Update () {
		huntPlayer ();
	}
	void huntPlayer(){
		float distanceToPlayer = Vector3.Distance (transform.position, player.position); // Obtem a distancia do jogador
		if (distanceToPlayer < 300 && distanceToPlayer > 5) { //Se estiver dentro do "raio" de perseguicao, persiga
			Vector3 Direction = (player.position - transform.position).normalized; //distancia normalizada
			transform.position += Direction * Time.deltaTime * speed; //avanca para o jogador
			Quaternion newRotationo = Quaternion.LookRotation (Direction);
			transform.rotation = newRotationo;
		}
		else{
			return;
		}
	}

	void OnCollisionEnter (Collision collision){
		if(collision.gameObject.tag == "Player"){ //Se na area de colisao for o jogador
			playerObject.increaseLife(-1); //reduz a vida do jogador
			if (playerObject.getLife() <= 0){ // se vida <= 0, acaba o jogo
				//Destroy(collision.gameObject); //PARA DESTRUIR LERPZ
				collision.gameObject.SetActive(false);
			}
			else{
				player.transform.position = new Vector3 (417.8f, 15f, 164.2f); //tda vez q morre, volta para a posicao inical
			}

			return;
		}
		if (collision.gameObject.tag == "Bullet") { //destruir a bala dps da colisao
			Destroy(gameObject);
			Destroy(collision.gameObject); //PARA DESTRUIR A BALA
		}
	}
}
