using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XJumpScript : MonoBehaviour {
	public bool jump = false;
	private Rigidbody2D rigi2D;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow) && !jump) {
			jump = true;
			transform.Translate (0, 1.5f, 0);
			GetComponent<Animator> ().SetBool ("isJumping", true);
		}

	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "FLOOR") {
			jump = false;
			GetComponent<Animator> ().SetBool ("isJumping", false);
		}
	}
}
