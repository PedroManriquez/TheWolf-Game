using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public float enemySpeed = 1.2f;
	private GameObject Player;
	private Vector3 startingPositionX;
	private GameObject Player1;
	private GameObject Player2;

	public int lives = 1;
	public int energy = 100;

	void Start () {
		Player1 = GameObject.Find ("Etiordep");
		Player2 = GameObject.Find ("Xineohp");
		startingPositionX = transform.position;
	}

	void FixedUpdate () {

		if (Mathf.Abs (transform.position.x - Player1.transform.position.x) < Mathf.Abs (transform.position.x - Player2.transform.position.x)) {
			Player = Player1;
		} else {
			Player = Player2;
		}


		if (Mathf.Abs (transform.position.x - Player.transform.position.x) < 4f) {


			transform.position = Vector2.MoveTowards (transform.position, Player.transform.position, enemySpeed * Time.deltaTime);

			if (transform.position.x > Player.transform.position.x) {
				GetComponent<SpriteRenderer> ().flipX = true;
			} else {
				GetComponent<SpriteRenderer> ().flipX = false;
			}

		} else {

			if (transform.position.x != startingPositionX.x) {
				if (transform.position.x > startingPositionX.x) {
					GetComponent<SpriteRenderer> ().flipX = true;
				} else {
					GetComponent<SpriteRenderer> ().flipX = false;
				}

				transform.position = Vector2.MoveTowards (transform.position, startingPositionX, enemySpeed * 2 * Time.deltaTime);
			} else {
				GetComponent<SpriteRenderer> ().flipX = true;
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			energy = energy - 25;
			if (energy == 0) {
				Destroy (gameObject);
			}
		}
	}

}
