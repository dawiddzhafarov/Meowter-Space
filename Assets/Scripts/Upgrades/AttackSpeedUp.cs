using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Upgrades/AttackSpeedUp")]
public class AttackSpeedUp : PowerUps
{
    public float attackCooldownReduction;
        
    public override void Apply() {
        var player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().attackCooldown *= attackCooldownReduction;
    }
}
