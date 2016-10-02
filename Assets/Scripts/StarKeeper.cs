using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class StarKeeper : MonoBehaviour {

    public enum Status {SUCCESS, FAILURE};

    private int numStars;

    private Text text;

	// Use this for initialization
	void Start () {
        numStars = 100;
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

    public Status UseStars(int numStarsToUse) {
        if (numStarsToUse <= numStars) {
            numStars -= numStarsToUse;
            UpdateDisplay();
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }

    private void UpdateDisplay() {
        text.text = numStars.ToString();
    }
}
