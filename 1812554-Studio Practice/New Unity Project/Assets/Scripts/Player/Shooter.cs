using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    

    public Transform Bullet;
    public float AttackRate;
    float rate;
    // Update is called once per frame
    void Update()
    {
        rate -= Time.deltaTime;
        if (Input.GetButton("Fire1"))
        {
            if(rate <= 0)
            {
                Instantiate(Bullet, transform.position, transform.rotation);
                rate = AttackRate;
            }
           
        }
    }
}
