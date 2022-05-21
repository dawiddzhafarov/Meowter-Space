using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawn : MonoBehaviour {
    public Wave[] Waves;
    private int currenWaveNumber = 0;
    private bool canSpawn = true;
    private float nextSpawnTime;
    private bool hasEnded = false;

    public UpgradeMenu upMenu;
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
            PowerUps[] available = new PowerUps[3];
            for (int i=0; i < 3; i++)
            {
                available[i] = currentWave.upgrade[i];
            }

            
            upMenu.Pause();
            //upMenu.up1.text = available[0].name;
            //upMenu.up1.text = available[1].name;
            //upMenu.up1.text = available[2].name;
            if (Input.GetKeyDown(KeyCode.Q))
            {
                upMenu.Resume();
            }
            // i bierzemy z tego np 3 upgrade'y i wyświetlamy nie wiem jak to zrobić :V
        }

    }
}
