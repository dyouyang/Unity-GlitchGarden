using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] attackers;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        foreach (GameObject attackerType in attackers) {
            if (IsTimeToSpawn(attackerType)) {
                Spawn(attackerType);
            }
        }
	}

    bool IsTimeToSpawn(GameObject attackerType) {

        // Get the inverse of the spawn interval to get the chance to spawn per second.
        float chanceToSpawn = 1 / attackerType.GetComponent<Attacker>().seenEverySeconds;

        // Normalize spawn per second to the framerate, and divide by 5 for number of spawners.
        chanceToSpawn = chanceToSpawn * Time.deltaTime / 5;

        // If random falls within the "spawns per second" rate, spawn.
        if (Random.value < chanceToSpawn) {
            return true;
        } else {
            return false;
        }
    }

    void Spawn(GameObject attackerType) {
        GameObject attacker = Instantiate(attackerType, this.transform.position, Quaternion.identity) as GameObject;
        attacker.layer = LayerMask.NameToLayer("Attacker");
        attacker.transform.parent = this.transform;
    }
}
