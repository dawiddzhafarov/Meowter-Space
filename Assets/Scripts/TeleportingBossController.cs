using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TeleportingBossController : MonoBehaviour {

    public GameObject teleportMarker;
    public GameObject projectile;

    private Health health;

    private float teleportCooldown = 2;

    private float numberOfBullets = 16;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TeleportCooldown());
        health = gameObject.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update() {
        
        //transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4))
        if (health.health < health.maxHealth / 2) {
            teleportCooldown = 1;
            numberOfBullets = 8;
        }

    }
    
    IEnumerator TeleportCooldown() {
        yield return new WaitForSeconds(teleportCooldown);
        teleportMarker.transform.position= new Vector3(Random.Range(-8, 8), Random.Range(-3, 3));
        yield return new WaitForSeconds(1);
        transform.position = teleportMarker.transform.position;
        teleportMarker.transform.position = transform.position;

        Shoot();
        StartCoroutine(TeleportCooldown());
    }

    private void Shoot() {
        for (int i = 0; i < numberOfBullets; i++) {
            var x = Mathf.Cos(i * 2 * Mathf.PI / numberOfBullets);
            var y = Mathf.Sin(i * 2 * Mathf.PI / numberOfBullets);

            GameObject throwableWeapon = Instantiate(projectile,
                transform.position + new Vector3(x, y), Quaternion.identity) as GameObject;
            throwableWeapon.GetComponent<Projectile>().direction = new Vector3(x, y);
            throwableWeapon.GetComponent<Projectile>().team = "Enemy";
            throwableWeapon.transform.localScale = new Vector3(1, 1, 1);
            throwableWeapon.GetComponent<Projectile>().damage = 5;
        }
    }

    //private void OnDestroy() {
   //     Destroy(teleportMarker);
    //}
}
