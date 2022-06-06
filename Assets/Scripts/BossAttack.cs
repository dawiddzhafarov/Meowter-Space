using System.Collections;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    private bool canAttack = true;
    public GameObject projectile;
    //public GameObject laser;
    public GameObject laserInstance;
    private Health _health;
    private bool canStartLaserForFirstTime = true;
    
    void Start() {
        _health = gameObject.GetComponent<Health>();
        //laserInstance = Instantiate(laser,
            //transform.position + new Vector3(-transform.localScale.x * 0.6f, 0), Quaternion.identity) as GameObject;
        laserInstance.SetActive(false);
    }
    
    void Update() {
        Attack();
        CreateLaserForFirstTime();
        //MoveLaser();
    }

   /* private void MoveLaser() {
        var laserPosition = transform.position;
        laserPosition.x += -laserInstance.transform.localScale.x / 2 - transform.localScale.x * 1.1f;
        laserInstance.transform.position = laserPosition;
    }*/

    private void CreateLaserForFirstTime() {
        if (_health.health < _health.maxHealth / 2 && canStartLaserForFirstTime) {
            laserInstance.SetActive(true);
            canStartLaserForFirstTime = false;
            StartCoroutine(laserFireingTime());
        }
    }

    private void Attack()
    {
        if (canAttack)
        {
            canAttack = false;
            GameObject throwableWeapon1 = Instantiate(projectile,
                transform.position + new Vector3(transform.localScale.x * 0.6f, transform.localScale.y*0.6f), Quaternion.identity) as GameObject;
            Vector2 direction1 = new Vector2(-1, 0);
            throwableWeapon1.GetComponent<Projectile>().direction = direction1;
            throwableWeapon1.GetComponent<Projectile>().team = "Enemy";

            throwableWeapon1.name = "ThrowableWeapon1";
            
            GameObject throwableWeapon2 = Instantiate(projectile,
                transform.position + new Vector3(transform.localScale.x * 0.6f, -transform.localScale.y*0.6f), Quaternion.identity) as GameObject;
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
    
    IEnumerator laserFireingTime()
    {
        yield return new WaitForSeconds(3.5f);
        laserInstance.SetActive(false);
        StartCoroutine(laserCooldown());
    }
    IEnumerator laserCooldown()
    {
        yield return new WaitForSeconds(5f);
        laserInstance.SetActive(true);
        StartCoroutine(laserFireingTime());
    }

    /*private void OnDestroy() {
        Destroy(laserInstance);
    }*/
}
