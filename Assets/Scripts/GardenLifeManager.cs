using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class GardenLifeManager : MonoBehaviour {

    public int gardenLife = 10;
    public Text lifeText;
    public LevelManager levelManager;

	void Start () {
        UpdateDisplay();
    }

    void OnTriggerEnter2D (Collider2D collider) {
        GameObject gameObject = collider.gameObject;
        if (gameObject.GetComponent<Attacker>()) {
            gardenLife--;
            UpdateDisplay();

            if (gardenLife <= 0) {
                LoseGame();
            }
        }
        Destroy(collider.gameObject);
    }

    private void LoseGame() {
        print("game lost");
        levelManager.LoadLevel("03b Lose");
    }

    private void UpdateDisplay() {
        lifeText.text = gardenLife.ToString();
    }
}
