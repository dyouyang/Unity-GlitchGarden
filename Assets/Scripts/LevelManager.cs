using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoLoadDelay;


	void Start () {
		AutoLoadNextLevel ();
	}

	public void AutoLoadNextLevel () {
		Invoke ("LoadNextLevel", autoLoadDelay);
	}

	public void LoadLevel(string name) {
		Debug.Log ("level load requested for " + name);
		Application.LoadLevel (name);
	}

	public void LoadNextLevel ()
	{
		Application.LoadLevel (Application.loadedLevel + 1);
	}

	public void QuitRequest() {
		Debug.Log ("Quit requested");
		Application.Quit ();
	}
}
