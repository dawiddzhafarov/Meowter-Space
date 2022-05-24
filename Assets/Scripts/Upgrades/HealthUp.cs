using UnityEngine;

[CreateAssetMenu(menuName = "Upgrades/HealthUp")]
public class HealthUp : PowerUps {

    public int extraHealth;
    [SerializeField] private Health health;
    //public Health healthObj;
    public override void Apply()
    {
        health.health = health.GetHealth() + extraHealth;
        
    }
}
