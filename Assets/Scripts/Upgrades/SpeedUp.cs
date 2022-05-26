using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Upgrades/SpeedUp")]
public class SpeedUp : PowerUps {
    public float extraSpeed;
        
    public override void Apply() {
        var player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().speed += extraSpeed;
    }
}
