using UnityEngine;
using System.Collections;

public class CoreSpawn : MonoBehaviour {

	public Rigidbody2D enemySmall;
	public Rigidbody2D spawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col)
	{	
		if (col.gameObject.tag == "Player")
		{
			Debug.Log ("hit");
			Vector3 spawnLocation1 = new Vector3(Random.Range (1.0F, 10.0F),0,0);
			Instantiate (enemySmall,spawnLocation1,transform.rotation);
		}
	}

}
