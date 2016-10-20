using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public float spawnTime = 3f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	// Use this for initialization
	void Start () {
		//Spawn ();
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void Spawn(){
		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		Instantiate (obj, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

//		//Instantiate (obj [Random.Range (0, obj.Length)], transform.position, Quaternion.identity);
//			Invoke ("Spawn", Random.Range (spawnMin, spawnMax));


}


}
