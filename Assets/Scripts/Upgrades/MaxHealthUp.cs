using UnityEngine;

[CreateAssetMenu(menuName = "Upgrades/MaxHealthUp")]
public class MaxHealthUp : PowerUps {

    public float extraHealth;
    
    public override void Apply()
    {
        var player = GameObject.Find("Player");
        float currentMaxHealth = player.GetComponent<Health>().GetMaxHealth();
        player.GetComponent<Health>().SetMaxHealth(currentMaxHealth + extraHealth);
    }
}
