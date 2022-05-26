using UnityEngine;

[CreateAssetMenu(menuName = "Upgrades/HealthUp")]
public class HealthUp : PowerUps {

    public float extraHealth;
    
    //[SerializeField] public GameObject player;
    //public static Health healthObj = new Health();
    // nie wiem jak przekazac obiekt Health
    public override void Apply()
    {
        var player = GameObject.Find("Player");
        //healthObj.SetHealth(healthObj.GetHealth() + extraHealth);
        float currentHealth = player.GetComponent<Health>().GetHealth();
        player.GetComponent<Health>().SetHealth(currentHealth + extraHealth);
    }
}
