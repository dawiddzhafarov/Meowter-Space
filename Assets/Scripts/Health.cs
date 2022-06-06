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
            else 
            {
                gameObject.GetComponent<SceneSwitcher>().DiedScene();
            }
        }
    }

    void ApplyDamage(float damage)
    {
        health -= damage;
        
    }
    
    public Statistics getStats()
    {
        return stats;
    }
    
    public float GetHealth()
    {
        return health;
    }
    public void SetHealth(float hp)
    {
        if (hp > health)
        {
            health = maxHealth;
        }
        else
        {
            health = hp;
        }
    }
    public float GetMaxHealth()
    {
        return maxHealth;
    }
    public void SetMaxHealth(float hp)
    {
        maxHealth = hp;
    }
}
