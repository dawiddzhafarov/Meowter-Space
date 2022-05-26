using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Upgrades/DashDistanceUp")]
public class DashDistanceUp : PowerUps {
    public float extraDashDistance;
    
    public override void Apply() {
        var player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().dashDistance += extraDashDistance;
    }
}
