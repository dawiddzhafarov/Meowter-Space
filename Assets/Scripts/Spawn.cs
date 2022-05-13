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
        else {
            currentWave.upgrade = currentWave.upgrade.OrderBy(n => Guid.NewGuid()).ToArray(); 
            // i bierzemy z tego np 3 upgrade'y i wyświetlamy nie wiem jak to zrobić :V
        }

    }
}
