using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsHistoryController : MonoBehaviour {

	public float tiempo;
	public int p;
	// Use this for initialization
	void Start () {
		StartCoroutine( WaitAndLoadScene ( tiempo, p) );
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator WaitAndLoadScene(float tiempo, int scene)
	{
		yield return new WaitForSeconds (tiempo);
		SceneManager.LoadScene (scene);
	}
}
