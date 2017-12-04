using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public float enemySpeed = 1.2f;
	private GameObject Player;
	private Vector3 startingPositionX;

	void Start () {
		Player = GameObject.Find ("Etiordep");
		startingPositionX = transform.position;
	}

	void Update () {


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

}
