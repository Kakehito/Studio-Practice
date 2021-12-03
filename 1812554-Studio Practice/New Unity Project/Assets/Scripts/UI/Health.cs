using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{    
   
    public Image[] healthPoints;

    public float health, maxhealth = 100;

    PlayerCharacter player;

    private void Start()
    {
        health = maxhealth;
        player = GetComponent<PlayerCharacter>();
    }

    private void Update()
    {    
        HealthFill();
    }
    void HealthFill()
    {
        for (int i = 0; i<healthPoints.Length; i++)
        {
            healthPoints[i].enabled = !DisplayHealthPoints(health, i);
        }
    }


    bool DisplayHealthPoints(float _health, int pointNumber)
    {
        return ((pointNumber * 10) >= _health);
    }
}
