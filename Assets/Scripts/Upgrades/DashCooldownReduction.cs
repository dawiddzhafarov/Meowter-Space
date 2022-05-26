using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Upgrades/DashCooldownReduction")]
public class DashCooldownReduction : PowerUps
{
    public float dashCooldownReduction;
        
    public override void Apply() {
        var player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().dashCooldown *= dashCooldownReduction;
    }
}
