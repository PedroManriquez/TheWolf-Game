using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParallaxController : MonoBehaviour {

	public float parallaxSpeed = 0.01f;

	public RawImage bkd1;
	public RawImage bkd2;
	public RawImage bkd3;
	public RawImage bkd4;
	public RawImage bkd5;
	public RawImage bkd6;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float finalSpeed = parallaxSpeed * Time.deltaTime;

		bkd1.uvRect = new Rect(bkd1.uvRect.x + finalSpeed, 0f, 1f, 1f);
		bkd2.uvRect = new Rect(bkd2.uvRect.x + finalSpeed * 2, 0f, 1f, 1f);
		bkd3.uvRect = new Rect(bkd3.uvRect.x + finalSpeed * 3, 0f, 1f, 1f);
		bkd4.uvRect = new Rect(bkd4.uvRect.x + finalSpeed * 4, 0f, 1f, 1f);
		bkd5.uvRect = new Rect(bkd5.uvRect.x + finalSpeed * 5, 0f, 1f, 1f);
		bkd6.uvRect = new Rect(bkd6.uvRect.x + finalSpeed * 6, 0f, 1f, 1f);
	}
}
