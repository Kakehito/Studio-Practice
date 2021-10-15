using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{

    public float FireRate;
    float rate;
    public Transform BulletType;
    private void Start()
    {
        rate = FireRate;
    }
        
    private void Update()
    {
        rate -= Time.deltaTime;

        if (rate <= 0)
        {
            Instantiate(BulletType, transform.position, transform.rotation);

            rate = FireRate;
        }
    }






}
