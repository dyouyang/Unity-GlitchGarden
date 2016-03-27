using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Attacker))]
public class Fox : MonoBehaviour {

    private Attacker attacker;
    private Animator animator;

	// Use this for initialization
	void Start () {
        attacker = GetComponent<Attacker>();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collider) {
        GameObject collidedWith = collider.gameObject;

        if (collidedWith.GetComponent<Defender>() != null) {

            if (collidedWith.GetComponent<Stone>() != null) {
                animator.SetTrigger("doJumpTrigger");
            } else {
                attacker.Attack(collidedWith);
            }
        }
    }
}
