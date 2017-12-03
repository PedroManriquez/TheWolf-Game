using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarraMovilController : MonoBehaviour {

	/*Objeto target de la plataforma movil*/
	public Transform target;

	/*Velovidad de movimiento de la plataforma*/
	public float speed;

	/*Se almacenan las posiciones iniciales*/
	private Vector3 start;
	private Vector3 end;

	// Use this for initialization
	void Start () {
		/*El target ya no es hijo de la plataforma*/
		if (target != null) {
			target.parent = null;
			start = transform.position;
			end = target.position;
		}
	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate (){
		/*Se comprueba si el target es distinto de nulo.
		Para asegurarse que se a asigando en la interfaz de unity*/
		if (target != null) {
			/*Se multiplica la velocidad por el time*/
			float fixedSpeed = speed * Time.deltaTime;

			/*MoveTowards = mover hacia un punto.
			Posee 3 valores, posicion actual, punto al cual ir, y la velocidad*/
			transform.position = Vector3.MoveTowards (transform.position, target.position, fixedSpeed);
		}

		/*se comprueba que la posicion actual de la plataforma sea igual a la posicion actual del target*/
		if (transform.position == target.position) {
			/*Se declara operador ternario condicional.
			Se cambia la posicion del target*/
			target.position = (target.position == start) ? end : start;
		}
	}
}
