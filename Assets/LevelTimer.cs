using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour {

    public float levelTimer = 60f;
    public LevelManager levelManager;
    public Text winText;

    private bool endedLevel = false;
	
	// Update is called once per frame
	void Update () {
        float timePercentage = Time.timeSinceLevelLoad / levelTimer;
        GetComponent<Slider>().value = timePercentage;

        if (Time.timeSinceLevelLoad >= levelTimer && !endedLevel) {
            WinLevel();
        }
	}

    private void WinLevel() {
        print("Level won!");
        endedLevel = true;
        winText.gameObject.SetActive(true);
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        Invoke("LoadNextLevel", audioSource.clip.length);
    }

    private void LoadNextLevel() {
        levelManager.LoadNextLevel();
    }
}
