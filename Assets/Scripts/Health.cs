using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public Statistics stats = new Statistics();
    // Start is called before the first frame update
    void Start() {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            if(gameObject.tag.Equals("Enemy")){
                stats.AddEnemiesKilled();
            }
        }
    }

    void ApplyDamage(float damage)
    {
        health -= damage;
        
    }

    public float GetHealth()
    {
        return health;
        
    }

    public Statistics getStats()
    {
        return stats;
    }
}
