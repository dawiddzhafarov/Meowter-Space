using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    //[SerializeField] private TextMeshProUGUI kills;
    //private Statistics statistics;
   // [SerializeField] private TextMeshProUGUI level;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        // timer should start counting after the game has started, not earlier.
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public void DiedScene()
    {
        SceneManager.LoadScene("DiedScene");
        //kills.text = $"Kills: {statistics.GetEnemiesKilled()}";
        //level.text = $"Levels passed: {statistics.GetLevel()}";
    }
}
