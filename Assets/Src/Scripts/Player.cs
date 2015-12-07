using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour {
	private int points;
	private int life;
	private int hole;
	private int pointsToLife;
	public Text pointsText; 
	public Text lifeText; 

	
	// Use this for initialization
	void Start () {
		points = 0;
		life = 5;
		hole = 4; //Distancia vertical a qual se ultrapassada o jogador perde uma vida (cair nos buracos)
		pointsToLife = 300; //Ao conseguir tantos pontos, ganhara uma vida
		setPointsText ();
		setLifeText ();
	}
	
	// Update is called once per frame
	void Update () {
		setPointsText ();//Exibir o texto dos pontos na tela
		setLifeText ();//Exibir o texto das vidas na tela
		if (isDropped ()) {
			increaseLife(-1);
			transform.position = new Vector3 (417.8f, 15f, 164.2f);
		}
	}

	void setLifeText(){
		lifeText.text = "Vidas: " + life.ToString ();
	}

	public void setPointsText(){
		pointsText.text = "Pontos: " + points.ToString ();
	}

	public void increasePoints(int value){
		points = points + value;
		if (points % pointsToLife == 0) {
			life = life + 1;
		}
	}

	public int getPoints(){
		return points;
	}

	public void increaseLife(int value){
		life = life + value;
		if (life <= 0) {
			gameObject.SetActive(false);
		}
	}

	public int getLife(){
		return life;
	}
	
	public bool isDropped(){
		if (transform.position.y <= hole) {
			return true;
		} else {
			return false;
		}
	}
}
