using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EtiordepUIController : MonoBehaviour {
	private EtiordepController etio;
	public GameObject etiordep;

	public GameObject live1;
	public GameObject live2;
	public GameObject live3;

	public GameObject energy;

	private float lengthHealth;

	// Use this for initialization
	void Start () {
		etio = etiordep.GetComponent<EtiordepController> ();
		lengthHealth = energy.GetComponent<RectTransform>().rect.width;
	}
	
	// Update is called once per frame
	void Update () {
		LifeUpdate ();
		EnergyUpdate ();
	}

	void LifeUpdate ()
	{
		if (etio.lives < 3) {
			live3.SetActive (false);
		} else if(etio.lives >= 3){
			live3.SetActive (true);
		}

		if (etio.lives < 2) {
			live2.SetActive (false);
		} else if(etio.lives >= 2){
			live2.SetActive (true);
		}

		if (etio.lives < 1) {
			live1.SetActive (false);
		} else if(etio.lives >= 1) {
			live1.SetActive (true);
		}

	}

	void EnergyUpdate ()
	{
		RectTransform auxImg = energy.GetComponent<RectTransform> ();

		if (etio.energy < 100 && etio.energy >= 1) {
			energy.GetComponent<RectTransform>().sizeDelta = new Vector2( (etio.energy * (lengthHealth/100)), auxImg.rect.height);
		} else if (etio.lives > 0){
			energy.GetComponent<RectTransform>().sizeDelta = new Vector2(lengthHealth, auxImg.rect.height);
		} else if (etio.lives == 0) {
			energy.GetComponent<RectTransform> ().sizeDelta = new Vector2 (0, auxImg.rect.height);
		}
	}
}
