using UnityEngine;
using System.Collections;

//Classe feita com base na aula do edirlei
public class MovePlatform : MonoBehaviour {
	public Transform pos1;
	public Transform pos2;

	private bool trade = false;
	private float speed = 0.1f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (trade) {
			transform.position = Vector3.MoveTowards (transform.position, pos1.position, speed);
		} else {
			transform.position = Vector3.MoveTowards (transform.position, pos2.position, speed);
		}

		if (transform.position == pos1.position) {
			trade = false;
		} else if(transform.position == pos2.position) {
			trade = true;
		}
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			other.gameObject.transform.parent = transform;
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Player") {
			other.gameObject.transform.parent = null;
		}
	}

}
