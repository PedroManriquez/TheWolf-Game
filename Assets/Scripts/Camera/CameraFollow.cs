using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject follow; 

	/*Posiciones min y max*/
	public Vector2 minCamPos, maxCamPos;

	/*Hace referencia a los segundos de retardo*/
	public float smoothTime;

	/*Para gestionar suavizado de forma vertical y horiontal*/
	private Vector2 velocity;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		/*Se actualiza la posicion de la cámara*/
		float posX = Mathf.SmoothDamp(transform.position.x, follow.transform.position.x, ref velocity.x, smoothTime);
		float posY = Mathf.SmoothDamp(transform.position.y, follow.transform.position.y, ref velocity.y, smoothTime);

		/*Clamp para limitar las posiciones de la cámara*/
		transform.position = new Vector3 (
			Mathf.Clamp(posX, minCamPos.x, maxCamPos.x),
			Mathf.Clamp(posY, minCamPos.y, maxCamPos.y), 
			transform.position.z);
	}
}
