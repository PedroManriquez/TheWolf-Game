using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EtiordepUIController : MonoBehaviour {
	private EtiordepController etio;
	public GameObject etiordep;

	public GameObject live1;
	public GameObject live2;
	public GameObject live3;

	// Use this for initialization
	void Start () {
		etio = etiordep.GetComponent<EtiordepController> ();
	}
	
	// Update is called once per frame
	void Update () {
		LifeUpdate ();
	}

	void LifeUpdate ()
	{
		if (etio.lives < 3) {
			live3.SetActive (false);
		} else {
			live3.SetActive (true);
		}

		if (etio.lives < 2) {
			live2.SetActive (false);
		} else {
			live2.SetActive (true);
		}

		if (etio.lives < 1) {
			live1.SetActive (false);
		} else {
			live2.SetActive (true);
		}

	}

	void EnergyUpdate ()
	{

	}
}
