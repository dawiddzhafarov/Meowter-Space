using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    private int EnemiesKilled = 0;
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
}
