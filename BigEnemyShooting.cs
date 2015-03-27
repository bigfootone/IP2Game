using UnityEngine;
using System.Collections;

public class BigEnemyShooting : MonoBehaviour {
	
	public Rigidbody2D projectile;
	private float fireRate = 0.6f;
	private float nextShot = 0;
	private float bulletSpeed = 600f;
	
		
	// Use this for initialization
	void Start () {	

	}
	
	// Update is called once per frame
	void Update () {
		

		Rigidbody2D shooting;

		if (Time.time > nextShot)
		{
		nextShot = Time.time + fireRate ;
		shooting = Instantiate (projectile, transform.position,Quaternion.Euler (0,0,90.0f)) as Rigidbody2D;
		shooting.velocity = GetComponent<Rigidbody2D>().velocity/3;
		shooting.AddForce (transform.up * bulletSpeed);


		shooting = Instantiate (projectile, transform.position,Quaternion.Euler (0,0,90.0f)) as Rigidbody2D;
		shooting.velocity = GetComponent<Rigidbody2D>().velocity/3;
		shooting.AddForce (transform.up * bulletSpeed);

		shooting = Instantiate (projectile, transform.position,Quaternion.Euler (0,0,90.0f)) as Rigidbody2D;
		shooting.velocity = GetComponent<Rigidbody2D>().velocity/3;
		shooting.AddForce (transform.up * bulletSpeed);

		}
	
	}
	
}
