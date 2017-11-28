using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GWalkScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("left")) {
			if (GetComponent<SpriteRenderer>().flipX == false) {
				GetComponent<SpriteRenderer>().flipX = true;
			}
			GetComponent<Animator>().SetBool ("isWalking", true);
			transform.Translate (-0.05f, 0, 0);
		}
		if (Input.GetKey("right")) {
			if (GetComponent<SpriteRenderer>().flipX == true) {
				GetComponent<SpriteRenderer>().flipX = false;
			}
			GetComponent<Animator> ().SetBool ("isWalking", true);
			transform.Translate (0.05f, 0, 0);
		}
		// Disabled animator
		if (Input.GetKeyUp("right") || Input.GetKeyUp("left")) {
			GetComponent<Animator> ().SetBool ("isWalking", false);
		}
	}
}
