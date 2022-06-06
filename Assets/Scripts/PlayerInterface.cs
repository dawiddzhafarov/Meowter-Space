using TMPro;
using UnityEngine;

public class PlayerInterface : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Health health;
    [SerializeField] private TextMeshProUGUI textHP;
    [SerializeField] private TextMeshProUGUI textEnemies;
    [SerializeField] private TextMeshProUGUI roundTime;
    //[SerializeField] private TextMeshProUGUI level;
    [SerializeField] private TextMeshProUGUI damage;
    [SerializeField] private TextMeshProUGUI bulletsPerShot;
    [SerializeField] private TextMeshProUGUI speed;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private TextMeshProUGUI dashDistance;
    [SerializeField] private TextMeshProUGUI dashCooldown;
    [SerializeField] private TextMeshProUGUI attackSpeed;
    private Statistics statistics = new Statistics();
    public static float time = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        
        attackSpeed.text = $"Attack Speed: {1 / playerMovement.attackCooldown}";
        
        dashCooldown.text = $"Dash Cooldown: {playerMovement.dashCooldown}";
        
        bulletsPerShot.text = $"Bullets per shot: {playerMovement.numberOfBullets}";
        
        speed.text = $"Speed: {playerMovement.speed}";

        dashDistance.text = $"Dash distance: {playerMovement.dashDistance}";
        
        damage.text = $"Damage: {playerMovement.damage}";
        
        StartTimer();
        
        int hp = (int)health.GetHealth();
        textHP.text = $"HP: {hp}/{health.maxHealth}";
        
        int kills = statistics.GetEnemiesKilled();
        textEnemies.text = $"Enemies killed: {kills}";
    }

    public void StartTimer()
    {
        //int min = Mathf.FloorToInt(Time.time  / 60);
        //int sec = Mathf.FloorToInt(Time.time % 60);
        int min = Mathf.FloorToInt(time / 60);
        int sec = Mathf.FloorToInt(time% 60);
        if ((sec >= 0 && sec <= 9) && (min >= 0 && min <= 9))
        {
            roundTime.text = "0" + min + ":0" + sec;
        }
        else
        {
            roundTime.text = min + ":" + sec;
        }
    }

    public void ResetTimer()
    {
        time = 0f;
    }
}
