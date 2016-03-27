using UnityEngine;
using System.Collections;
using System;

[RequireComponent (typeof(Animator))]
public class Attacker : MonoBehaviour {

    [Range (-2f, 2f)]
    public float walkSpeed;
    private GameObject currentTarget;

    private Animator animator;

    // Use this for initialization
    void Start () {
        Rigidbody2D rigidBody = gameObject.AddComponent<Rigidbody2D>();
        rigidBody.isKinematic = true;

        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 movementVector = Vector3.left * walkSpeed * Time.deltaTime;
        transform.Translate(movementVector);
        //this.transform.position += movementVector;

        // If our target died, resume moving.
        if (currentTarget == null) {
            animator.SetBool("isAttacking", false);
        }
	}

    void OnTriggerEnter2D() {
        Debug.Log(name + " OnTriggerEnter2D");
    }

    public void Attack(GameObject target) {
        currentTarget = target;
        animator.SetBool("isAttacking", true);
    }

    /**
    Change the walking speed, called from animation events.    
    **/
    public void setWalkSpeed (float newSpeed) {
        walkSpeed = newSpeed;
    }
    
    // Called from attack animation
    public void StrikeCurrentTarget(float damage) {
        Debug.Log(name + " striking " + currentTarget.name + " for " + damage.ToString() + " damage");
        Health currentTargetHealth = currentTarget.GetComponent<Health>();
        currentTargetHealth.takeDamageToHealth(damage);
    }
}
