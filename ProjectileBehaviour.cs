using UnityEngine;
using System.Collections;

public class ProjectileBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D damage)
	{
		if (damage.gameObject.tag == "Enemy") 
		{
			Destroy (this.gameObject);
		}

		if (damage.gameObject.tag == "Wall") 
		{
			Destroy (this.gameObject);
		}
	

	}
}
