using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour 
{
	public AudioSource aullido;

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void StartGame(int p) 
	{
		//AudioSource audio = GetComponent<AudioSource> ();
		//audio.clip = aullido;
		aullido.Play ();

		StartCoroutine( WaitAndLoadScene ( aullido.clip.length, p) );

		//WaitForSeconds (2);


	}

	public void ExitGame () 
	{
		#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
		#else
			Application.Quit();
		#endif
	}

	IEnumerator WaitAndLoadScene(float num, int scene)
	{
		//Debug.Log ("Wait? " + num);
		yield return new WaitForSeconds (num);
		SceneManager.LoadScene (scene);
	}
}
