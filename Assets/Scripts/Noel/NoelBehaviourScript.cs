using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoelBehaviourScript : MonoBehaviour {

	public float enemySpeed = 1.2f;
	private GameObject Player;
	private Vector3 startingPositionX;
	private Animator anim;

	void Start () {
		Player = GameObject.Find ("Etiordep");
		startingPositionX = transform.position;
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate () {

		anim.SetBool ("isWalking", false);

		if (Mathf.Abs (transform.position.x - Player.transform.position.x) < 4f) {
			anim.SetBool ("isWalking", true);

			transform.position = Vector2.MoveTowards (transform.position, Player.transform.position, enemySpeed * Time.deltaTime);

			if (transform.position.x > Player.transform.position.x) {
				GetComponent<SpriteRenderer> ().flipX = true;
			} else {
				GetComponent<SpriteRenderer> ().flipX = false;
			}
			

		} else {

			if (Mathf.Abs(transform.position.x - startingPositionX.x)>1) {
				anim.SetBool ("isWalking", true);

				if (transform.position.x > startingPositionX.x) {
					GetComponent<SpriteRenderer> ().flipX = true;
				} else {
					GetComponent<SpriteRenderer> ().flipX = false;
				}

				transform.position = Vector2.MoveTowards (transform.position, startingPositionX, enemySpeed * 2 * Time.deltaTime);
			} else {
				anim.SetBool ("isWalking", false);
				GetComponent<SpriteRenderer> ().flipX = true;
			}
		}
	}
}
