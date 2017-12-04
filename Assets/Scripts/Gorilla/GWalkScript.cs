using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GWalkScript : MonoBehaviour {

	public float enemySpeed = 1.2f;
	private GameObject Player;
	private Vector3 startingPositionX;
	private Animator anim;

	private bool isPunching = false;

	public int lives = 1;
	public int energy = 1000;

	void Start () {
		Player = GameObject.Find ("Etiordep");
		startingPositionX = transform.position;
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate () {
		anim.SetBool ("isWalking", false);

		if (Mathf.Abs (transform.position.x - Player.transform.position.x) < 6f) {

			if (Mathf.Abs (transform.position.x - Player.transform.position.x) < 3.5f) {
				isPunching = true;
				anim.SetBool ("isPunching", isPunching);
			} else {
				isPunching = false;
				anim.SetBool ("isPunching", isPunching);
			}

			if (!isPunching) {

				anim.SetBool ("isWalking", true);

				transform.position = Vector2.MoveTowards (transform.position, Player.transform.position, enemySpeed * Time.deltaTime);

				if (transform.position.x > Player.transform.position.x) {
					GetComponent<SpriteRenderer> ().flipX = true;
				} else {
					GetComponent<SpriteRenderer> ().flipX = false;
				}
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

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			energy -= 50;
			if (energy == 0) {
				GameManager.instance.Win ();
				anim.SetBool("isDie", true);
				Destroy (gameObject, 1f);
			}
		}
	}
}
