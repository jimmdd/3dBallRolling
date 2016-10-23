using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelChange : MonoBehaviour {
	public int nextStage;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			GameObject.Find ("GameManager").GetComponent<fading> ().LoadStage (SceneManager.GetActiveScene ().buildIndex+1);
		}
	}
}