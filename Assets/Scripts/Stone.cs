using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {

    void OnTriggerStay2D(Collider2D other) {
        Attacker attacker = other.gameObject.GetComponent<Attacker>();
        if (attacker) {
            GetComponent<Animator>().SetTrigger("underAttack");
            print("attacker triggered");
        }
    }
}
