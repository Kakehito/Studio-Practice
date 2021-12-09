using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform toSpawn;
    public float spawnRate;
    public bool isRepeatable;
    float spawner;

    bool hasSpawned = false;

    private void Start()
    {
        spawner = spawnRate;

        if(isRepeatable)
        InvokeRepeating("RepeatSpawner",Time.deltaTime,spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasSpawned)
        spawner -= Time.deltaTime;

        if (!isRepeatable)
        {
            if (spawner <= 0)
            {
                Instantiate(toSpawn, transform.position, transform.rotation);
                spawner = spawnRate;
                hasSpawned = true;
            }
        }       

    }

    void RepeatSpawner()
    {
        Instantiate(toSpawn, transform.position, transform.rotation);
    }
}
