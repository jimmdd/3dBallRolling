using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {
	HUD hud;
	void start(){
		transform.RotateAround (transform.position, transform.up, Time.deltaTime * 90f);
	}

	void OnTriggerEnter(Collider other){
		if(other.tag =="Player"){
		if (this.tag == "Coin" ) {
			//for display increased score
			hud = GameObject.Find ("Camera").GetComponent<HUD> ();
			//TO-DO decrease from time
			hud.IncreaseScore (20);
			Destroy (this.gameObject);
		}

			if(this.tag =="Emerald"){
				// do ball size change
				Destroy(this.gameObject);
			}
		}
	}
}
