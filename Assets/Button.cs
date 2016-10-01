using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown () {
        print(name + " clicked");
        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>();
        renderer.color = Color.black;
    }
}
