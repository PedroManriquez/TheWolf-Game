using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasMenuController : MonoBehaviour {
	public float parallaxSpeed = 0.01f;
	public RawImage moon;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Loop");
		float speed = parallaxSpeed * Time.deltaTime;

		//moon.uvRect = new Rect( 0f, moon.uvRect.y + speed *2, 1f, 1f);	
		moon.transform.Translate (0, speed * -2, 0);
	}
}
