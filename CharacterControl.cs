using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {

	float moveSpeedCharacter = 8.0f;





	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		bool downMove = Input.GetKey (KeyCode.S);
		bool upMove = Input.GetKey (KeyCode.W);
		bool leftMove = Input.GetKey (KeyCode.A);
		bool rightMove = Input.GetKey (KeyCode.D);

				/*bool downMove = Input.GetAxis ("360_moveY")>0;
				bool upMove = Input.GetAxis ("360_moveY")<0;
				bool noMoveY = Input.GetAxis ("360_moveY") == 0;
				bool leftMove = Input.GetAxis ("360_moveX")<0;
				bool rightMove = Input.GetAxis ("360_moveX")>0;
				bool noMoveX = Input.GetAxis ("360_moveX") == 0;*/



				if (downMove) 
				{
						rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, -moveSpeedCharacter);
				} 

				else if (upMove) 
				{
						rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, moveSpeedCharacter);
				} 

				else
						rigidbody2D.velocity = new Vector2 (rigidbody2D.velocity.x, 0);



				if (leftMove) 
				{
						rigidbody2D.velocity = new Vector2 (-moveSpeedCharacter, rigidbody2D.velocity.y);
				} 

				else if (rightMove) 
				{
						rigidbody2D.velocity = new Vector2 (moveSpeedCharacter, rigidbody2D.velocity.y);
				}

				else
						rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
				
		}


}
