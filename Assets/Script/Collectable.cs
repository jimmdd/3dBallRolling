using UnityEngine;
using System.Collections;
public class Collectable : MonoBehaviour {
	HUD hud;
	//  void start(){
	//      transform.RotateAround (transform.position, transform.up, Time.deltaTime * 90f);
	//  }
	void update(){
		//make the gameobject rotate itself
		transform.Rotate(new Vector3(0,Time.deltaTime*50,0));
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
				//ball size change smaller
				if (other.transform.localScale.x > .5f) {
					other.GetComponent<PlayerController> ().jumpForce = 1000f;
					other.transform.localScale += new Vector3 (-0.5f, -0.5f, -0.5f);
					norotate.translate = -.51f;
					Destroy (this.gameObject);
				}
			}
			if (this.tag == "Ruby") {
				//ball size change bigger
				if (other.transform.localScale.x < 1f) {
					other.GetComponent<PlayerController> ().jumpForce = 1600f;
					other.transform.localScale += new Vector3 (0.5f, 0.5f, 0.5f);
					norotate.translate = -1f;
					Destroy (this.gameObject);
				}
			}
		}
	}
}
