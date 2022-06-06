using UnityEngine;

public class Statistics
{
    private static int EnemiesKilled = 0;

    public void AddEnemiesKilled()
    {
        EnemiesKilled++;
    }

    public int GetEnemiesKilled()
    {
        return EnemiesKilled;
    }
    
    public void Reset()
    {
        EnemiesKilled = 0;
    }

    public void resetTimer()
    {
        PlayerInterface.time = 0f;
    }

    public float GetTime()
    {
        return PlayerInterface.time;
    }

    public string GetTimeString()
    {
        int min = Mathf.FloorToInt(PlayerInterface.time / 60);
        int sec = Mathf.FloorToInt(PlayerInterface.time% 60);
        if ((sec >= 0 && sec <= 9) && (min >= 0 && min <= 9))
        {
            return "0" + min + ":0" + sec;
        }
        return min + ":" + sec;
    }
}