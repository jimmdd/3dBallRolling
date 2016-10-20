using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	HUD hud;
	void start(){
		transform.RotateAround (transform.position, transform.up, Time.deltaTime * 90f);
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			//for display increased score
			hud = GameObject.Find ("Camera").GetComponent<HUD> ();
			hud.IncreaseScore (20);
			Destroy (this.gameObject);
		}
	}
}
