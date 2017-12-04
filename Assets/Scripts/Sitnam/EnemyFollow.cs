using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public float enemySpeed = 1.2f;
	private GameObject Player;
	private Vector3 startingPositionX;
	private bool isPunching = false;

	public int lives = 1;
	public int energy = 100;
	public Animator anim;
	private bool live;

	void Awake () {
		anim = GetComponent<Animator> ();
	}
	void Start () {
		Player = GameObject.Find ("Etiordep");
		startingPositionX = transform.position;
		live = true;
	}

	void FixedUpdate () {
		if (Mathf.Abs (transform.position.x - Player.transform.position.x) < 3.5f && live) {
			isPunching = true;
			anim.SetBool ("isPunching", isPunching);
		} else {
			isPunching = false;
			anim.SetBool ("isPunching", isPunching);
		}

		if (Mathf.Abs (transform.position.x - Player.transform.position.x) < 4f && live) {

			anim.SetBool ("isWalk", true);
			transform.position = Vector2.MoveTowards (transform.position, Player.transform.position, enemySpeed * Time.deltaTime);

			if (transform.position.x > Player.transform.position.x) {
				GetComponent<SpriteRenderer> ().flipX = true;
			} else {
				GetComponent<SpriteRenderer> ().flipX = false;
			}

		} else if (live) {

			if (transform.position.x != startingPositionX.x) {
				if (transform.position.x > startingPositionX.x) {
					GetComponent<SpriteRenderer> ().flipX = true;
				} else {
					GetComponent<SpriteRenderer> ().flipX = false;
				}
				anim.SetBool ("isWalk", true);
				transform.position = Vector2.MoveTowards (transform.position, startingPositionX, enemySpeed * 2 * Time.deltaTime);
			} else {
				GetComponent<SpriteRenderer> ().flipX = true;
				anim.SetBool ("isWalk", false);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			energy = energy - 25;
			if (energy == 0) {
				anim.SetBool ("isDie", true);
				live = false;
				Destroy (gameObject, 2f);
			}
		}
	}

}
