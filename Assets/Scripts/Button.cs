using UnityEngine;
using System.Collections;
using System;

public class Button : MonoBehaviour {

    private SpriteRenderer spriteRenderer;

    public GameObject defenderObject;

	// Use this for initialization
	void Start () {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnMouseDown () {
        ButtonManager.clear();
        ButtonManager.selectedButton = this;
        setSelected(true);
    }

    internal void setSelected(bool selected) {
        if (selected) {
            spriteRenderer.color = Color.white;
        } else {
            spriteRenderer.color = Color.black;
        }
    }
}
