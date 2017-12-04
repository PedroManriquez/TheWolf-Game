using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XJumpScript : MonoBehaviour {
	public bool jump = false;
	private Rigidbody2D rigi2D;
	public float jumpForce = 800f;
	// Use this for initialization
	void Start () {
		rigi2D = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow) && !jump) {
			jump = true;
			rigi2D.AddForce (new Vector2 (0f, jumpForce));
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
