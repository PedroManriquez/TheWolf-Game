using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour {

	public Transform target;
	public float enemySpeed = 0.5f;

	void Start () {
		
	}

	void Update () {
		
		transform.position = Vector2.Lerp (transform.position, target.position, enemySpeed * Time.deltaTime);
	}

}
