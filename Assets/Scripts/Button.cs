using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Button : MonoBehaviour {

    private SpriteRenderer spriteRenderer;

    public GameObject defenderObject;

	// Use this for initialization
	void Start () {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        SetupCost();
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

    /*
    Update child text display with the defender prefab's star cost.
    */
    void SetupCost() {
        int cost = defenderObject.GetComponent<Defender>().starCost;
        GetComponentInChildren<Text>().text = cost.ToString();
    }
}
