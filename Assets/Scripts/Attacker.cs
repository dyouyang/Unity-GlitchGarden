using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

    [Range (-2f, 2f)]
    public float walkSpeed;

	// Use this for initialization
	void Start () {
        Rigidbody2D rigidBody = gameObject.AddComponent<Rigidbody2D>();
        rigidBody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movementVector = Vector3.left * walkSpeed * Time.deltaTime;
        transform.Translate(movementVector);
        //this.transform.position += movementVector;
	}

    void OnTriggerEnter2D() {
        Debug.Log(name + " OnTriggerEnter2D");
    }
    
    /**
    Change the walking speed, called from animation events.    
    **/
    public void setWalkSpeed (float newSpeed) {
        walkSpeed = newSpeed;
    }
}
