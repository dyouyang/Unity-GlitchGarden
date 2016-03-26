using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Attacker))]
public class Lizard : MonoBehaviour {

    Attacker attacker;

	// Use this for initialization
	void Start () {
        attacker = GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider) {

        if (collider.gameObject.GetComponent<Defender>() != null) {
            // We collided with a defender object
            attacker.Attack(collider.gameObject);
        }
    }
}
