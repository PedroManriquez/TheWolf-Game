using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XineohpUIController : MonoBehaviour {
	private XineohpController xine;
	public GameObject xineohp;

	public GameObject live1;
	public GameObject live2;
	public GameObject live3;

	// Use this for initialization
	void Start () {
		xine = xineohp.GetComponent<XineohpController> ();
	}
	
	// Update is called once per frame
	void Update () {
		LifeUpdate ();
	}

	void LifeUpdate ()
	{
		if (xine.lives < 3) {
			live3.SetActive (false);
		} else {
			live3.SetActive (true);
		}

		if (xine.lives < 2) {
			live2.SetActive (false);
		} else {
			live2.SetActive (true);
		}

		if (xine.lives < 1) {
			live1.SetActive (false);
		} else {
			live2.SetActive (true);
		}
			
	}

	void EnergyUpdate ()
	{
		
	}
}
