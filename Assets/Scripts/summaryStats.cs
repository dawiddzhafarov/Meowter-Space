using TMPro;
using UnityEngine;

public class summaryStats : MonoBehaviour
{
    private static Statistics stats = new Statistics();
    [SerializeField] TextMeshProUGUI enemiesKilled;
    [SerializeField] TextMeshProUGUI levelsPassed;
    [SerializeField] private TextMeshProUGUI totalTime;
    // Start is called before the first frame update
    void Start()
    {
        enemiesKilled.text = $"Enemies kiled: {stats.GetEnemiesKilled()}";
        totalTime.text = $"Time: {stats.GetTimeString()}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
