using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public float enemySpeed = 0.5f;
	private GameObject Player;
	private Rigidbody2D rigi2D;

	void Start () {
		Player = GameObject.Find ("Etiordep");
		rigi2D = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, Player.transform.position, enemySpeed * Time.deltaTime);

		if (transform.position.x > Player.transform.position.x) {
			GetComponent<SpriteRenderer> ().flipX = true;
		} else {
			GetComponent<SpriteRenderer> ().flipX = false;
		}
	}

}
