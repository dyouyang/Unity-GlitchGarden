using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class StarKeeper : MonoBehaviour {

    private int numStars;

    private Text text;

	// Use this for initialization
	void Start () {
        numStars = 0;
        text = GetComponent<Text>();
        UpdateDisplay();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddStars(int numStarsToAdd) {
        numStars += numStarsToAdd;
        UpdateDisplay();
    }

    public void UseStars(int numStarsToUse) {
        numStars -= numStarsToUse;
        UpdateDisplay();
    }

    private void UpdateDisplay() {
        text.text = numStars.ToString();
    }
}
