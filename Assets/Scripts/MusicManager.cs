using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip [] clipForLevel;

	private AudioSource audioSource;

	void Awake () {
		DontDestroyOnLoad (gameObject);
	}

	void OnLevelWasLoaded (int level) {
		if (clipForLevel [level] != null) {
			audioSource.clip = clipForLevel[level];
			audioSource.loop = true;
			audioSource.Play();
		}
	}

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}

}
