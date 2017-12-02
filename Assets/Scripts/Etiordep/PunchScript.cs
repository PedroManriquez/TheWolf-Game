using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchScript : MonoBehaviour {
	public AudioSource punchSound;

	private bool isPunch = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.J)) {
			if(!isPunch)
				punchSound.Play ();

			isPunch = true;
			GetComponent<Animator> ().SetBool ("isPunch", true);
		}

		if (Input.GetKeyUp(KeyCode.J)) {
			if(isPunch)
				punchSound.Stop ();
			
			isPunch = false;
			GetComponent<Animator> ().SetBool ("isPunch", false);
		}
	}
}
