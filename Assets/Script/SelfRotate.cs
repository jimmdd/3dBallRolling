using UnityEngine;
using System.Collections;

public class SelfRotate : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		//make the gameobject rotate itself
		transform.Rotate(new Vector3(Time.deltaTime*50,0,0));
	}
}
