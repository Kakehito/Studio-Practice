using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct wave
{
    public GameObject[] enemies;
    public bool isCompleted;
}

public class WaveSpawner : MonoBehaviour
{
    int currentWave;
    public wave[] waves;
    
    void Start()
    {
        SpawnWave(0);
      for(int x = 0; x <= waves.Length; x++)
        {
            waves[x].isCompleted = false;
        }
    }
        
    void Update()
    {
        
    }

    void SpawnWave(int waveNumber)
    {
        foreach(GameObject b in waves[waveNumber].enemies)
        {
            b.SetActive(true);
          //  Instantiate(b, transform.position, transform.rotation);
        }
    }

    bool CheckForCompletion()
    {
        int numberOfCompletedWaves = 0;
        foreach(wave i in waves)
        {
            if (i.isCompleted)
            {
                numberOfCompletedWaves++;
            }
        }
        if (numberOfCompletedWaves == waves.Length)
        {
            return true;
        }
        else
            return false;
    }
}
