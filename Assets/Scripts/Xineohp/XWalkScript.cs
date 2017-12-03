using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XWalkScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)) {
			if (GetComponent<SpriteRenderer>().flipX == true) {
				GetComponent<SpriteRenderer>().flipX = false;
			}
			GetComponent<Animator>().SetBool ("isWalking", true);
			transform.Translate (0.09f, 0, 0);
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			if (GetComponent<SpriteRenderer>().flipX == false) {
				GetComponent<SpriteRenderer>().flipX = true;
			}
			GetComponent<Animator> ().SetBool ("isWalking", true);
			transform.Translate (-0.09f, 0, 0);
			
		}
		// Disabled animator
		if (Input.GetKeyUp (KeyCode.RightArrow) || Input.GetKeyUp (KeyCode.LeftArrow)) {
			GetComponent<Animator> ().SetBool ("isWalking", false);
		}
	}

}
