using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool canAttack = true;
    public GameObject projectile;
    private float dashTime = 2;
    private bool isDashed = false;
    public float speed;

    private float timer = 0.0f;
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
    }

    private void Attack()
    {
        if (canAttack)
        {
            canAttack = false;
            GameObject throwableWeapon = Instantiate(projectile,
                transform.position + new Vector3(transform.localScale.x * 0.6f, 0), Quaternion.identity) as GameObject;
            //Vector2 direction = new Vector2(transform.localScale.x, 0);
            //throwableWeapon.GetComponent<Projectile>().direction = direction;
            throwableWeapon.GetComponent<Projectile>().team = "Player";

            throwableWeapon.name = "ThrowableWeapon";
            StartCoroutine(AttackCooldown());
        }
    }

    IEnumerator AttackCooldown()
    {
        yield return new WaitForSeconds(0.5f);
        canAttack = true;
    }
    
    void UpdateMovement()
    {
        rb.velocity=(new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0        ) * speed);
    }

    void Dash()
    {
        if (Input.GetKey(KeyCode.LeftShift) && !isDashed)
        {
            float newSpeed = speed + 3;
            rb.velocity=(new Vector3(
                Input.GetAxis("Horizontal"),
                Input.GetAxis("Vertical"),
                0        ) * newSpeed);
            
        }
    }
}
