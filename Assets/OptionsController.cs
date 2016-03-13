using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

    public Slider volumeSlider;

    public LevelManager levelManager;

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();

        musicManager = GameObject.FindObjectOfType<MusicManager>();
    }

    // Update is called once per frame
    void Update () {
        musicManager.SetVolume(volumeSlider.value);
    }

    public void SaveOptionsAndBack() {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        levelManager.LoadLevel("01a Start Menu");
    }
}
