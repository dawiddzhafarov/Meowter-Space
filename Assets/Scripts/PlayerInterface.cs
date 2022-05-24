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
    [SerializeField] private Projectile projectile;
    
    private Statistics statistics = new Statistics();
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bulletsPerShot.text = $"Bullets per shot: {playerMovement.numberOfBullets}";
        
        speed.text = $"Speed: {playerMovement.speed}";

        dashDistance.text = $"Dash distance: {playerMovement.dashDistance}";
        //get damage, dont know if its going to work with upgrades
        damage.text = $"Damage: {playerMovement.damage}";
        
        //get level
        level.text = "LEVEL: 1";
        
        //roundTime.text = Time.time.ToString();
        startTimer();
        
        int hp = (int)health.GetHealth();
        textHP.text = $"HP: {hp}/{health.maxHealth}";
        
        int kills = statistics.GetEnemiesKilled();
        textEnemies.text = $"Enemies killed: {kills}";
    }

    public void startTimer()
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
