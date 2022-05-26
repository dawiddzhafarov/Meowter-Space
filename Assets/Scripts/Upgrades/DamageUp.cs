using UnityEngine;

[CreateAssetMenu(menuName = "Upgrades/DamageUp")]
public class DamageUp : PowerUps {

    public float extraDamage;
        
    public override void Apply() {
        var player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().damage += extraDamage;
    }
}
