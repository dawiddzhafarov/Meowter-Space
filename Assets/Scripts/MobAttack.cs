using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobAttack : MonoBehaviour
{
    private bool canAttack = true;
    public float attackColldown;
    public float attackDamage;

    public GameObject projectile;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Attack();
    }
    private void Attack()
    {
        if (canAttack)
        {
            canAttack = false;
            GameObject throwableWeapon = Instantiate(projectile,
                transform.position + new Vector3(-transform.localScale.x*0.6f, 0), Quaternion.identity) as GameObject;
            Vector2 direction = new Vector2(-1, 0);
            throwableWeapon.GetComponent<Projectile>().direction = direction;
            throwableWeapon.GetComponent<Projectile>().team = "Enemy";
            throwableWeapon.GetComponent<Projectile>().damage = attackDamage;

            throwableWeapon.name = "ThrowableWeapon1";

            
            StartCoroutine(AttackCooldown());
        }
    }
    IEnumerator AttackCooldown()
    {
        yield return new WaitForSeconds(attackColldown);
        canAttack = true;
    }
}
