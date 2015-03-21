using UnityEngine;
using System.Collections;

public class EnemyProjectileBehaviour : MonoBehaviour {

	private Animator pewPew;


	void Start () {
			
	}




	void Update() {
	

	}

	void OnCollisionEnter2D(Collision2D damage)
	{

		if (damage.gameObject.tag == "Wall") 
		{
			Destroy (this.gameObject);
		}
	

	}
}
