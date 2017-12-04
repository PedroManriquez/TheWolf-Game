using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public float enemySpeed = 0.5f;
	private GameObject Player;

	void Start () {
		Player = GameObject.Find ("Etiordep");
	}

	void Update () {
		transform.position = Vector2.MoveTowards (transform.position, Player.transform.position, enemySpeed * Time.deltaTime);
	}

}
