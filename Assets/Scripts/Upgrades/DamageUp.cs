using UnityEngine;

[CreateAssetMenu(menuName = "Upgrades/DamageUp")]
public class DamageUp : PowerUps {

    public float extraDamage;
        
    public override void Apply() {
        player.GetComponent<PlayerMovement>().damage += extraDamage;
    }
}
