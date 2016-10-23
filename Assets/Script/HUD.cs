using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour {

	public float playerScore = 0;
	GUIStyle scoreStyle = new GUIStyle();
	int posX = 0;
	int posY = 0;

	void Start(){
		//scale size font base on screen
		scoreStyle.fontSize = (int)(40.0f * (float)(Screen.width)/1920.0f);
		scoreStyle.fontStyle = FontStyle.Bold;
		scoreStyle.alignment = TextAnchor.MiddleCenter;
		posX = (int)(Screen.width / 2 - 10);
		posY = (int)(Screen.height / 20);
	}

	void Update(){
		playerScore += Time.deltaTime;
	}

	//store store when disabled
	void onDisable(){
		PlayerPrefs.SetInt ("Score", (int)playerScore);
	}

	//get method to return playerscore
	public float getScore (){
		return playerScore;
	}

	//method to increase score
	public void IncreaseScore(int amount){
		playerScore += amount;
	}

	//display score on GUI
	void OnGUI(){
		GUI.Label (new Rect (posX, posY, 100, 50), "Score: " + (int)playerScore, scoreStyle);
	}

}
