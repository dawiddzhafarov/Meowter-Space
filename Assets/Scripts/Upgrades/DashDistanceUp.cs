using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Upgrades/DashDistanceUp")]
public class DashDistanceUp : PowerUps {
    public float extraDashDistance;
    
    public override void Apply() {
        player.GetComponent<PlayerMovement>().dashDistance += extraDashDistance;
    }
}
