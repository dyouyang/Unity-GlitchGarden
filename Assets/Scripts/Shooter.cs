using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public GameObject gun;

    public GameObject axe;
    public GameObject projectilesParent;

    private void FireGun () {
        GameObject axeProjectile = Instantiate(axe, gun.transform.position, Quaternion.identity) as GameObject;
        axeProjectile.transform.parent = projectilesParent.transform;
    }
}
