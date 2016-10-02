using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

    private StarKeeper starKeeper;

	// Use this for initialization
	void Start () {
        starKeeper = FindObjectOfType<StarKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D() {
        Debug.Log(name + " OnTriggerEnter2D");
    }

    public void AddStars(int numStarsToAdd) {
        starKeeper.AddStars(numStarsToAdd);
    }
}
