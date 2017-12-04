using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XineohpController : MonoBehaviour {
	public int lives = 3;
	public int energy = 60;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy") {
			energy = energy - 1;
			if (energy == 0) {
				energy = 100;
				--lives;
			}

			//saludText.text = "Salud: " + salud;
		}
	}
}
