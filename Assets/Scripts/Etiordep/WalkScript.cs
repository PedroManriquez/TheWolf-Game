using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey(KeyCode.D)) {
			if (GetComponent<SpriteRenderer>().flipX == true) {
				GetComponent<SpriteRenderer>().flipX = false;
			}
			GetComponent<Animator>().SetBool ("isWalking", true);
			transform.Translate (0.09f, 0, 0);
		}
		if (Input.GetKey(KeyCode.A)) {
			if (GetComponent<SpriteRenderer>().flipX == false) {
				GetComponent<SpriteRenderer>().flipX = true;
			}
			GetComponent<Animator> ().SetBool ("isWalking", true);
			transform.Translate (-0.09f, 0, 0);
			
		}
		// Disabled animator
		if (Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.D)) {
			GetComponent<Animator> ().SetBool ("isWalking", false);
		}
	}

}
