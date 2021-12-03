using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{    
    public Image healthBar;
    public List<Image> healthPoints;

    float health, maxHealth = 100;
    float lerpSpeed;

    PlayerCharacter player;

    private void Start()
    {
        health = maxHealth;

        player = GetComponent<PlayerCharacter>();
    }

    private void Update()
    {        
        if (health > maxHealth) health = maxHealth;
                
        lerpSpeed = 3f * Time.deltaTime;
      
        //HealthBarFiller();        
    }

    //void HealthBarFiller()
    //{
    //    healthBar.fillAmount = Mathf.Lerp(healthBar.fillAmount, health / maxHealth, lerpSpeed);

    //    for(int i=0; i < healthPoints.Length; i++)
    //    {
    //        healthPoints[i].enabled = !DisplayHealthPoint(health, i);
    //    }
    //}

    public void UpdateHealth()
    {
        List<Image> t;
        t = healthPoints;
        healthPoints.Clear();
        for(int x = player.Health; x >= 0; x--)
        {
            healthPoints.Add(t[x]);
        }
    }

    bool DisplayHealthPoint(float _health, int pointNumber)
    {
        return ((pointNumber * 10) >= _health);
    }
        
    public void Damage(float damagePoints)
    {
        if (health > 0)
            health -= damagePoints;
    }

    public void Heal(float healingPoints)
    {
        if (health < maxHealth)
            health += healingPoints;
    }
}
