using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{
    public int Health = 2;

    private void Update()
    {
        if (Input.GetButtonDown("Bomb"))
        {
            Health -= 10;
        }
        if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }


}
