using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoots : MonoBehaviour
{
    private bool canAttack = true;

    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }
    private void Attack()
    {
        if (canAttack)
        {
            canAttack = false;
            GameObject throwableWeapon1 = Instantiate(projectile,
                transform.position + new Vector3(transform.localScale.y * 0.6f, transform.localScale.x*0.6f), Quaternion.identity) as GameObject;
            Vector2 direction1 = new Vector2(-1, 0);
            throwableWeapon1.GetComponent<Projectile>().direction = direction1;
            throwableWeapon1.GetComponent<Projectile>().team = "Enemy";

            throwableWeapon1.name = "ThrowableWeapon1";
            
            GameObject throwableWeapon2 = Instantiate(projectile,
                transform.position + new Vector3(transform.localScale.y * 0.6f, -transform.localScale.x*0.6f), Quaternion.identity) as GameObject;
            Vector2 direction2 = new Vector2(-1, 0);
            throwableWeapon2.GetComponent<Projectile>().direction = direction2;
            throwableWeapon2.GetComponent<Projectile>().team = "Enemy";

            throwableWeapon2.name = "ThrowableWeapon2";
            
            StartCoroutine(AttackCooldown());
        }
    }
    IEnumerator AttackCooldown()
    {
        yield return new WaitForSeconds(0.5f);
        canAttack = true;
    }
}
