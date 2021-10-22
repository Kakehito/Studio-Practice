using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{

    public float TimeBeforeStart;
    public float FireRate;
    public Transform Bullet;


    float rate;




    private void Update()
    {
        TimeBeforeStart -= Time.deltaTime;
        rate -= Time.deltaTime;
        if(TimeBeforeStart <= 0)
        {

            if(rate <= 0)
            {




                Shoot();
                rate = FireRate;




            }

        }
    }




    void Shoot()
    {

        Instantiate(Bullet, transform.position, transform.localRotation);
    }


}
