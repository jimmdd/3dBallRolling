using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class norotate : MonoBehaviour {

	public static float translate = -.51f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		transform.position = GameObject.Find ("Player").transform.position;
		transform.Translate (0,translate,0);
	}
}
