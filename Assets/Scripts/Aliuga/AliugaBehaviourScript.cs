using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliugaBehaviourScript : MonoBehaviour {

	public float enemySpeed = 1.2f;
	private GameObject Player, Player1, Player2;
	private Vector3 startingPositionX;
	private bool twoPlayers;

	public int lives = 1;
	public int energy = 150;
	public Animator anim;
	private bool live;
	private bool isQuiet;
	void Start () {
		Player1 = GameObject.Find ("Etiordep");
		if (GameObject.Find ("Xineohp") != null) {
			Player2 = GameObject.Find ("Xineohp");
			twoPlayers = true;
		} else {
			twoPlayers = false;
		}
		startingPositionX = transform.position;
		anim = GetComponent<Animator> ();
		live = true;
		isQuiet = true;
	}

	void FixedUpdate () {
		if (twoPlayers) {

			if (Mathf.Abs (transform.position.x - Player1.transform.position.x) < Mathf.Abs (transform.position.x - Player2.transform.position.x)) {
				Player = Player1;
			} else {
				Player = Player2;
			}
		} else {
			Player = Player1;
		}

		if (isQuiet) {
			anim.SetBool("isFly", false);
		}
		if (live) {
			if (Mathf.Abs (transform.position.x - Player.transform.position.x) < 4f) {
				anim.SetBool("isFly", true);
				isQuiet = false;
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
						isQuiet = true;
					}
					anim.SetBool("isFly", true);
					isQuiet = false;
					transform.position = Vector2.MoveTowards (transform.position, startingPositionX, enemySpeed * 2 * Time.deltaTime);
				} else {
					GetComponent<SpriteRenderer> ().flipX = true;
				}
			}
		}
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Player") {
			energy = energy - 25;
			if (energy == 0) {
				live = false;
				anim.SetBool("isDie", true);
				Destroy (gameObject, 1.4f);
			}
		}
	}
}
