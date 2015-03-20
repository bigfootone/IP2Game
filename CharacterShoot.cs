using UnityEngine;
using System.Collections;

public class CharacterShoot : MonoBehaviour {

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
	

		bool downShoot = Input.GetKey (KeyCode.DownArrow);
		bool upShoot = Input.GetKey (KeyCode.UpArrow);
		bool leftShoot = Input.GetKey (KeyCode.LeftArrow);
		bool rightShoot = Input.GetKey (KeyCode.RightArrow);
	

		if ((downShoot) && Time.time > nextShot)
		{
			nextShot = Time.time + fireRate;
			shooting = Instantiate (projectile, transform.position,transform.rotation) as Rigidbody2D;
			shooting.transform.rotation = Quaternion.AngleAxis (180,Vector3.down);
			shooting.velocity = rigidbody2D.velocity/3;
			shooting.AddForce (transform.up *-bulletSpeed);

		}

		if ((upShoot) && Time.time > nextShot)
		{
			nextShot = Time.time + fireRate;
			shooting = Instantiate (projectile, transform.position,transform.rotation) as Rigidbody2D;
			shooting.velocity = rigidbody2D.velocity/3;
			shooting.rigidbody2D.AddForce (transform.up * bulletSpeed);

		}

		if ((leftShoot) && Time.time > nextShot)
		{
			nextShot = Time.time + fireRate;
			shooting = Instantiate (projectile, transform.position,transform.rotation) as Rigidbody2D;
			shooting.velocity = rigidbody2D.velocity/3;
			shooting.AddForce (transform.right *-bulletSpeed);
		}

		if ((rightShoot) && Time.time > nextShot)
		{
			nextShot = Time.time + fireRate;
			shooting = Instantiate (projectile, transform.position,transform.rotation) as Rigidbody2D;
			shooting.velocity = rigidbody2D.velocity/3;
			shooting.AddForce (transform.right *bulletSpeed);
		}


	}
}
