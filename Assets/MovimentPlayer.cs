using UnityEngine;
using System.Collections;

public class MovimentPlayer : MonoBehaviour {
	private Transform player;
	// Use this for initialization
	void Start () {
		//player = (CharacterController)GetComponent (typeof()
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, 0, Time.deltaTime * 100);
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate(0, 0, -Time.deltaTime * 100);
		}
		else if (Input.GetKey(KeyCode.RightArrow)){
			transform.Translate (Time.deltaTime*100, 0, 0);
		}
		else if (Input.GetKey(KeyCode.LeftArrow)){
			transform.Translate (-Time.deltaTime*100, 0, 0);
		}
		//player.Translate (Time.deltaTime, 0, 0);

	}
}
