﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EtiordepController : MonoBehaviour {
	public int lives = 3;
	public int energy = 100;

	//private int salud = 10;
	//public Text saludText;

	// Use this for initialization
	void Start () {
		//saludText.text = "Salud: " + salud;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy") {
			energy = energy - 10;
			if (energy == 0) {
				energy = 100;
				--lives;
			}
				
			//saludText.text = "Salud: " + salud;
		}
	}
}
