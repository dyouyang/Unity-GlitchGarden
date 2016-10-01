using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public GameObject gun;

    public GameObject axe;
    private GameObject projectilesParent;

    private const string PROJECTILES_NAME = "Projectiles";
    void Start () {
        projectilesParent = GameObject.Find(PROJECTILES_NAME);
        if (projectilesParent == null) {
            projectilesParent = new GameObject(PROJECTILES_NAME);
        }
    }
    private void FireGun () {
        GameObject axeProjectile = Instantiate(axe, gun.transform.position, Quaternion.identity) as GameObject;
        axeProjectile.transform.parent = projectilesParent.transform;
    }
}
