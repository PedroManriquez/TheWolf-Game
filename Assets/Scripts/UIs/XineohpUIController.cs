using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XineohpUIController : MonoBehaviour {
	private XineohpController xine;
	public GameObject xineohp;

	public GameObject live1;
	public GameObject live2;
	public GameObject live3;

	public GameObject energy;

	private float lengthHealth;

	// Use this for initialization
	void Start () {
		xine = xineohp.GetComponent<XineohpController> ();
		lengthHealth = energy.GetComponent<RectTransform>().rect.width;
	}
	
	// Update is called once per frame
	void Update () {
		LifeUpdate ();
		EnergyUpdate ();
	}

	void LifeUpdate ()
	{
		if (xine.lives < 3) {
			live3.SetActive (false);
		} else if(xine.lives >= 3){
			live3.SetActive (true);
		}

		if (xine.lives < 2) {
			live2.SetActive (false);
		} else if(xine.lives >= 2){
			live2.SetActive (true);
		}

		if (xine.lives < 1) {
			live1.SetActive (false);
		} else if(xine.lives >= 1) {
			live1.SetActive (true);
		}
			
	}

	void EnergyUpdate ()
	{
		RectTransform auxImg = energy.GetComponent<RectTransform> ();

		if (xine.energy < 100 && xine.energy >= 1) {
			energy.GetComponent<RectTransform>().sizeDelta = new Vector2( (xine.energy * (lengthHealth/100)), auxImg.rect.height);
		} else {
			energy.GetComponent<RectTransform>().sizeDelta = new Vector2(lengthHealth, auxImg.rect.height);
		}
	}
}
