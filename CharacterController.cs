using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	string Player = "Player1";
	Rigidbody2D Rigidbody;
	Animator Animator;
	bool Grounded;	
	float MovementSpeed = 40;

	// Use this for initialization
	void Start () {
		Rigidbody = GetComponent<Rigidbody2D>();
		Animator = GetComponent<Animator> ();
	}

	
	// Update is called once per frame
	void Update () {
		MovementInput ();
	}

	void MovementInput(){
		if (Input.GetAxis ("Horizontal" + Player) > 0.01) {
			Rigidbody.AddForce (new Vector2 (MovementSpeed, 0));
			Animator.SetBool("MovingFront",true);
			Animator.SetBool("MovingBack",false);
			
		} else if (Input.GetAxis ("Horizontal" + Player) < -0.01) {
			Rigidbody.AddForce (new Vector2 (-MovementSpeed, 0));
			Animator.SetBool("MovingBack",true);
			Animator.SetBool("MovingFront",false);
			
			
		} else {
			
			Animator.SetBool("MovingFront",false);
			Animator.SetBool("MovingBack",false);
			
		}


	}

	void OnCollisionEnter2D(Collision2D other){

	}
}
