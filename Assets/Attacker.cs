using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

    [Range (-2f, 2f)]
    public float walkSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movementVector = Vector3.left * walkSpeed * Time.deltaTime;
        transform.Translate(movementVector);
        //this.transform.position += movementVector;
	}
}
