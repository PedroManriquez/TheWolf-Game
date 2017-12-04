using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public float enemySpeed = 0.5f;
	private GameObject Player;
	private Vector3 startingPositionX;

	void Start () {
		Player = GameObject.Find ("Etiordep");
		startingPositionX = transform.position;
	}

	void Update () {

		if (Mathf.Abs (transform.position.x - Player.transform.position.x) < 5f) {

			transform.position = Vector2.MoveTowards (transform.position, Player.transform.position, enemySpeed * Time.deltaTime);

			if (transform.position.x > Player.transform.position.x) {
				GetComponent<SpriteRenderer> ().flipX = true;
			} else {
				GetComponent<SpriteRenderer> ().flipX = false;
			}
		} else {
			transform.position = Vector2.MoveTowards (transform.position, startingPositionX, enemySpeed * Time.deltaTime);
		}
	}

}
