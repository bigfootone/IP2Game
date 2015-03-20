using UnityEngine;
using System.Collections;

public class EnemyBehaviour : MonoBehaviour {

	public int health = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (health == 0) 
		{
			Destroy (this.gameObject);
		}				

	}

	void OnCollisionEnter2D(Collision2D getHit)
	{
		if (getHit.gameObject.tag == "Projectile") 
		{
			health = health - 1;
		}

	}
}
