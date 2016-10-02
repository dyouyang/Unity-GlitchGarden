using UnityEngine;
using System.Collections;

public class DefenderSpawner : MonoBehaviour {

    public Camera camera;

    private GameObject defenderParent;
    private const string PARENT_NAME = "Defenders";

    private StarKeeper starKeeper;

	// Use this for initialization
	void Start () {
        defenderParent = GameObject.Find(PARENT_NAME);
        if (defenderParent == null) {
            defenderParent = new GameObject(PARENT_NAME);
        }

        starKeeper = FindObjectOfType<StarKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /*
    On mouse click, spawn a defender in the grid that the mouse clicked inside.
    */
    void OnMouseDown () {
        print("mouse down " + SnapToGrid(WorldPointOfMouseClick()));

        GameObject defenderType = ButtonManager.selectedButton.defenderObject;
        StarKeeper.Status status = starKeeper.UseStars(defenderType.GetComponent<Defender>().starCost);

        if (status == StarKeeper.Status.SUCCESS) {
            GameObject defenderObj = Instantiate(defenderType, SnapToGrid(WorldPointOfMouseClick()), Quaternion.identity) as GameObject;
            defenderObj.transform.parent = defenderParent.transform;
        } else {
            Debug.Log("Insufficient stars to buy");
        }
    }

    Vector2 WorldPointOfMouseClick () {
        return camera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
    }

    Vector2 SnapToGrid(Vector2 rawWorldPos) {
        return new Vector2(Mathf.RoundToInt(rawWorldPos.x), Mathf.RoundToInt(rawWorldPos.y));
    }
}
