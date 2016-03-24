using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider;
    public Slider difficultySlider;

    public LevelManager levelManager;

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();

        musicManager = GameObject.FindObjectOfType<MusicManager>();
    }

    // Update is called once per frame
    void Update () {
        musicManager.SetVolume(volumeSlider.value);
    }

    public void SaveOptionsAndBack() {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultySlider.value);
        levelManager.LoadLevel("01a Start Menu");
    }

    public void SetDefaults() {
        volumeSlider.value = 0.75f;
        difficultySlider.value = 2;
    }
}
