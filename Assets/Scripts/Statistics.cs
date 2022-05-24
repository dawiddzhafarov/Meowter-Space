using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics
{
    private static int EnemiesKilled = 0;

    private static int level = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddEnemiesKilled()
    {
        EnemiesKilled++;
    }

    public int GetEnemiesKilled()
    {
        return EnemiesKilled;
    }

    public int GetLevel()
    {
        return level;
    }
}
