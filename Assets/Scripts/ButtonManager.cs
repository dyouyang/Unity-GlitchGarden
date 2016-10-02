using UnityEngine;
using System.Collections;
using System;

public class ButtonManager : MonoBehaviour {

    private static Button [] buttons;

    internal static Button selectedButton;

	// Use this for initialization
	void Start () {
        buttons = FindObjectsOfType<Button>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    internal static void clear() {
        foreach (Button button in buttons) {
            button.setSelected(false);
        }
    }
}
