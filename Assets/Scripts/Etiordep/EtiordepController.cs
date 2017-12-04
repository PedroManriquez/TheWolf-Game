using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EtiordepController : MonoBehaviour {

	private int salud = 10;
	public Text saludText;

	// Use this for initialization
	void Start () {
		saludText.text = "Salud: " + salud;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy") {
			salud = salud - 1;
			saludText.text = "Salud: " + salud;
		}
	}
}
