using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    public Vector2 direction= Vector2.right;
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
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.tag.Equals(team))
        {
            collision.gameObject.SendMessage("ApplyDamage", damage);
            Destroy(gameObject);
        }

    }
}
