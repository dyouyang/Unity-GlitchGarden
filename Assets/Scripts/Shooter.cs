using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public GameObject gun;

    public GameObject axe;
    private GameObject projectilesParent;

    public void Update () {
        if (CanSeeAttacker()) {
            SetAttacking(true);
        } else {
            SetAttacking(false);
        }
    }

    private bool CanSeeAttacker() {
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, Vector2.right, Mathf.Infinity, LayerMask.GetMask("Attacker"));
        return hit;
    }

    private void SetAttacking(bool attacking) {
        this.GetComponent<Animator>().SetBool("isAttacking", attacking);
    }

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
