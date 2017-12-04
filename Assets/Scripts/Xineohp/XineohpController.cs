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
		if (col.gameObject.tag == "Enemy" && lives >= 0) {

			if(energy != 0)
				energy = energy - 10;

			if (energy == 0 && lives > 0) {
				energy = 60;
				--lives;
			}

			//saludText.text = "Salud: " + salud;
		}
	}
}
