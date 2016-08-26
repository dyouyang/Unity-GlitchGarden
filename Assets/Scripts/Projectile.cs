using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    public float speed;
    public float damage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
	}

    /*
    If we hit something, damage it and destroy self if it is an attacker.
    We're assuming projectiles are only fired by Defenders with this.
    */
    void OnTriggerEnter2D(Collider2D collider) {
        GameObject gameObject = collider.gameObject;
        Debug.Log("Projectile hit");
        if (gameObject.GetComponent<Attacker>() != null) {
            Health health = gameObject.GetComponent<Health>();
            health.takeDamageToHealth(damage);
            Destroy(this.gameObject);
        }
    }
}
