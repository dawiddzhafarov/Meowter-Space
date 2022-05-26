using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool canAttack = true;
    public GameObject projectile;
    private bool canDash = true;
    public float dashDistance;
    public int numberOfBullets;
    public float damage;
    public float speed;
    public float attackCooldown;
    public float dashCooldown;
    public GameObject ghost;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
        Dash();
        Attack();
       
		//ghost.rb.MovePosition(rb.position+rb.velocity.normalized*dashDistance);
    }
    private void Attack()
    {
        if (canAttack) {
            canAttack = false;
            
            for (int i = 0; i < numberOfBullets; i++) {
                
                GameObject throwableWeapon = Instantiate(projectile,
                    transform.position + new Vector3(transform.localScale.x * 0.6f, 0.10f*(numberOfBullets-1)-0.20f*i), Quaternion.identity) as GameObject;
                //Vector2 direction = new Vector2(transform.localScale.x, 0);
                //throwableWeapon.GetComponent<Projectile>().direction = direction;
                throwableWeapon.GetComponent<Projectile>().team = "Player";
                throwableWeapon.GetComponent<Projectile>().damage = damage;
                throwableWeapon.name = "ThrowableWeapon";
            }
            StartCoroutine(AttackCooldown());
        }
    }

    IEnumerator AttackCooldown()
    {
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }
    
    void UpdateMovement()
    {
        rb.velocity=(new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0        ) * speed);
    }
    
    void Dash() {
        
        if(!canDash) 
            ghost.SetActive(false);
        else
        {
            ghost.SetActive(true);
        }
        
        ghost.transform.position = rb.position + rb.velocity.normalized * dashDistance;
        if (Input.GetKey(KeyCode.LeftShift) && canDash && rb.velocity.magnitude !=0 ) {
            rb.MovePosition(rb.position+rb.velocity.normalized*dashDistance);
            //rb.AddForce(rb.velocity.normalized*3f, ForceMode2D.Force);
            canDash = false;
            StartCoroutine(DashCooldown());
        }
    }
    IEnumerator DashCooldown()
    {
        yield return new WaitForSeconds(dashCooldown);
        canDash = true;
    }
}
