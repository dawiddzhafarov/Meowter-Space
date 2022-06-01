using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDealDamage : MonoBehaviour {
    private bool canDealDamage;

    public float damage;
    public float tickRate;
    // Start is called before the first frame update
    void Start() {
        canDealDamage = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable() {
        canDealDamage = true;
    }


    private void OnTriggerStay2D(Collider2D other) {
        
        if (canDealDamage && other.tag.Equals("Player")) {
            canDealDamage = false;
            other.gameObject.SendMessage("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
            StartCoroutine(AttackCooldown());
        }    
    }


    IEnumerator AttackCooldown()
    {
        yield return new WaitForSeconds(tickRate);
        canDealDamage = true;
    }
}
