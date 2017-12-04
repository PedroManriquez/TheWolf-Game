using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public static GameManager instance = null;
	public GameObject winText;
	public GameObject deathText;
	public bool live = true;
	public float resetDelay;
    public int nextIndexLevel;
	void Update () {
	}
	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);
	}
	public void IsLive (float life) {
		live = life > 0f;
	}
	public bool GetLiveState () {
		return live;
	}
	public void Win () {
		winText.SetActive (true);
		StartCoroutine( WaitAndLoadScene ( 2f, nextIndexLevel) );
	}
	public void Die () {
		deathText.SetActive (true);
		Time.timeScale = .9f;
		Invoke ("Reset", resetDelay);
	}
	void Reset () {
		Time.timeScale = 1.0f;
		Application.LoadLevel (Application.loadedLevel);
	}
    IEnumerator WaitAndLoadScene(float num, int scene)
	{
		//Debug.Log ("Wait? " + num);
		yield return new WaitForSeconds (num);
		SceneManager.LoadScene (scene);
	}
}
