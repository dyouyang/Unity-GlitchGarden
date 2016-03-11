using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanelFader : MonoBehaviour {

    public float duration;

    private Image image;
    private Color startColor = Color.black;

	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.timeSinceLevelLoad < duration) {

            // My solution
            float alpha = 1 - Time.timeSinceLevelLoad / duration;
            image.GetComponent<CanvasRenderer>().SetAlpha(alpha);


            // Instructor solution
            //float alpha = Time.deltaTime / duration;
            //startColor.a -= alpha;
            //image.color = startColor;
        } else {
            gameObject.SetActive(false);
        }
	}
}
