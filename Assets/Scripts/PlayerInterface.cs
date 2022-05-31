using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInterface : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Health health;
    [SerializeField] private TextMeshProUGUI textHP;
    [SerializeField] private TextMeshProUGUI textEnemies;
    [SerializeField] private TextMeshProUGUI roundTime;
    [SerializeField] private TextMeshProUGUI level;
    [SerializeField] private TextMeshProUGUI damage;
    [SerializeField] private TextMeshProUGUI bulletsPerShot;
    [SerializeField] private TextMeshProUGUI speed;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private TextMeshProUGUI dashDistance;
    [SerializeField] private TextMeshProUGUI dashCooldown;
    [SerializeField] private TextMeshProUGUI attackSpeed;
    private Statistics statistics = new Statistics();
    public float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attackSpeed.text = $"Attack Speed: {1 / playerMovement.attackCooldown}";
        
        dashCooldown.text = $"Dash Cooldown: {playerMovement.dashCooldown}";
        
        bulletsPerShot.text = $"Bullets per shot: {playerMovement.numberOfBullets}";
        
        speed.text = $"Speed: {playerMovement.speed}";

        dashDistance.text = $"Dash distance: {playerMovement.dashDistance}";
        //get damage, dont know if its going to work with upgrades
        damage.text = $"Damage: {playerMovement.damage}";
        
        //get level
        level.text = "LEVEL: 1";
        
        //roundTime.text = Time.time.ToString();
        //StartTimer();
        
        int hp = (int)health.GetHealth();
        textHP.text = $"HP: {hp}/{health.maxHealth}";
        
        int kills = statistics.GetEnemiesKilled();
        textEnemies.text = $"Enemies killed: {kills}";
    }

    public void StartTimer()
    {
        int min = Mathf.FloorToInt(Time.time / 60);
        int sec = Mathf.FloorToInt(Time.time % 60);
        if ((sec >= 0 && sec <= 9) && (min >= 0 && min <= 9))
        {
            roundTime.text = "0" + min + ":0" + sec;
        }
        else
        {
            roundTime.text = min + ":" + sec;
        }
    }
}
