using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Projectile : MonoBehaviour
{
    
    public Vector3 direction= Vector2.right;
    public float speed;

    public float damage;

    public string team;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody2D>().velocity = direction * speed;
        GetComponent<Transform>().localPosition += direction * speed * Time.deltaTime;
    }

   /* void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.tag.Equals(team))
        {
            collision.gameObject.SendMessage("ApplyDamage", damage);
            Destroy(gameObject);
        }

    }*/

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.tag.Equals(team))
        {
            
            col.gameObject.SendMessage("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject);
        }

    }
}
