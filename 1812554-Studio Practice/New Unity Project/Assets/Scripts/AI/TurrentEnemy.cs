using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurrentEnemy : MonoBehaviour
{

    Transform Player;




    public Transform Bullet;
    public Transform Shooter;
    public float FireRate;
    public float AttackRange;

    float rate;
    private void Start()
    {
        Player = GameManager.instance.PlayerCharacter;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerCharacter>().Health = 0;
        }
    }

    private void Update()
    {
     
       if(Vector3.Distance(transform.position, Player.position) <= AttackRange)
        {
            rate -= Time.deltaTime;
            if(rate <= 0)
            {
                transform.LookAt(Player);
                Instantiate(Bullet, transform.position, Shooter.rotation);
                rate = FireRate;
            }
           
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, AttackRange);
    }
}
