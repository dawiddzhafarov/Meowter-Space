using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class FactoryBossController : MonoBehaviour
{
    // Start is called before the first frame update
    private bool canDealContactDamage;
    private GameObject[] shieldWall = new GameObject[3];
    public GameObject shield;
    private float healthTreshold = 90;
    private Health health;
    [Serialize] public GameObject[] spawnableEnemies;
    void Start()
    {
        canDealContactDamage = true;
        health = gameObject.GetComponent<Health>();
        SpawnShieldWall();
        StartCoroutine(SpawnEnemy());
    }



    // Update is called once per frame
    void Update()
    {
        if (health.health < healthTreshold) {
            healthTreshold -= 10;
            SpawnShieldWall();
        }
    }
    private void SpawnShieldWall() {
        if (shieldWall[0] == null) {
            shieldWall[0] = Instantiate(shield, new Vector3(9.25f, 2.25f, 0), shield.transform.rotation);
        }
        if (shieldWall[1] == null) {
            shieldWall[1] = Instantiate(shield, new Vector3(7.75f, 0, 0), shield.transform.rotation);
        }
        if (shieldWall[2] == null) {
            shieldWall[2] = Instantiate(shield, new Vector3(9.25f, -2.25f, 0), shield.transform.rotation);
        }

        
        
    }

    private void OnCollisionStay2D(Collision2D collision) {
        if (canDealContactDamage && collision.gameObject.tag.Equals("Player")) {
            canDealContactDamage = false;
            collision.gameObject.SendMessage("ApplyDamage", 5, SendMessageOptions.DontRequireReceiver);
            StartCoroutine(ContactDamageCooldown());
        }  
    }

    private void OnTriggerStay2D(Collider2D other) {
  
    }
    IEnumerator ContactDamageCooldown()
    {
        yield return new WaitForSeconds(0.5f);
        canDealContactDamage= true;
    }
    IEnumerator SpawnEnemy()
    {
        Instantiate(spawnableEnemies[Random.Range(0,spawnableEnemies.Length)], new Vector3(8f, Random.Range(4,-4), 0), shield.transform.rotation);
        yield return new WaitForSeconds(5f);
        StartCoroutine(SpawnEnemy());
    }
}
