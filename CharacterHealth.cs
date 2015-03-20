using UnityEngine;
using System.Collections;

public class CharacterHealth : MonoBehaviour {

	public int playerHealth = 5;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	/*void Update () {

		if (playerHealth == 0) 
		{
			kill player and go to gameover state
		}
	
	}
	*/

	
	void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.gameObject.tag == "EnemyProjectile") 
		{
			playerHealth = playerHealth - 1;
		}

		if (enemyHit.gameObject.tag == "Enemy") 
		{
			playerHealth = playerHealth - 1;
		}
		
	}




}
