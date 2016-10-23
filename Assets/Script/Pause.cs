using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	void Update(){
		if (Input.GetKeyDown(KeyCode.P))
		{
			doPause ();
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			Esc("StartMenu");
		}
	}
	public void doPause(){
		if (Time.timeScale == 1) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}

	}

	public void Esc(string SceneName){
		SceneManager.LoadScene (SceneName);
	}
}
