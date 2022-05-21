using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour {
    public Wave[] Waves;
    private int currenWaveNumber = 0;
    private bool canSpawn = true;
    private float nextSpawnTime;
    private bool hasEnded = false;

    public UpgradeMenu upMenu;

    //[SerializeField] private TextMeshProUGUI up1;
    //[SerializeField] private TextMeshProUGUI up2;
    //[SerializeField] private TextMeshProUGUI up3;

    //public Button test;

    public Button button1;
    public Button button2;
    public Button button3;
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        var currentWave = Waves[currenWaveNumber];
        if (currentWave.upgrade.Length == 0) {
            if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0) {
                canSpawn = true;
                nextSpawnTime = Time.time - 1;
            }


            if (canSpawn && nextSpawnTime < Time.time) {
                foreach (var enemy in currentWave.EnemySpawns) {
                    Instantiate(enemy.enemy, enemy.position, enemy.enemy.transform.rotation);
                }

                nextSpawnTime = Time.time + currentWave.spawnInterval;
                if (currentWave.spawnInterval == 0) {
                    canSpawn = false;
                }

                if (currenWaveNumber + 1 != Waves.Length) {
                    currenWaveNumber++;
                }
            }
        }
        else if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0 && !hasEnded)
        {
            hasEnded = true;
            currentWave.upgrade = currentWave.upgrade.OrderBy(n => Guid.NewGuid()).ToArray();
            
            button1.onClick.AddListener(currentWave.upgrade[0].Apply);
            button1.onClick.AddListener(upMenu.Resume);
            button1.GetComponentInChildren<TextMeshProUGUI>().text = currentWave.upgrade[0].name;
            
            button2.onClick.AddListener(currentWave.upgrade[1].Apply);
            button2.onClick.AddListener(upMenu.Resume);
            button2.GetComponentInChildren<TextMeshProUGUI>().text = currentWave.upgrade[1].name;
            
            button3.onClick.AddListener(currentWave.upgrade[2].Apply);
            button3.onClick.AddListener(upMenu.Resume);
            button3.GetComponentInChildren<TextMeshProUGUI>().text = currentWave.upgrade[2].name;
            upMenu.Pause();
            
            //up1.text = available[0].name;
            //up2.text = available[1].name;
            //up3.text = available[2].name;
            //upMenu.up1.text = available[2].name;
            if (Input.GetKeyDown(KeyCode.Q))
            {
                upMenu.Resume();
            }
            // i bierzemy z tego np 3 upgrade'y i wyświetlamy nie wiem jak to zrobić :V
        }

    }
}
