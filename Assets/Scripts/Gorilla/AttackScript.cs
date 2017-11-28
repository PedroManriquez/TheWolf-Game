using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.G)) {
			GetComponent<Animator> ().SetBool ("isPunch", true);
		}
		if (Input.GetKeyUp(KeyCode.G)) {
			GetComponent<Animator> ().SetBool ("isPunch", false);
		}
	}
}
