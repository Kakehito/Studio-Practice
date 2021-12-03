using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class EnemyBullet : MonoBehaviour
{
    public float speed;
    Rigidbody RB;

    private void Start()
    {
        Invoke("destruct", 3);
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
        RB.velocity = (transform.forward * speed) * Time.deltaTime;
        if (Input.GetButtonDown("Bomb"))
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            if(collision.transform.GetComponent<PlayerCharacter>().Shield <= 0)
            {
                collision.transform.GetComponent<PlayerCharacter>().Health-=10;
                collision.transform.GetComponent<Health>().health = collision.transform.GetComponent<PlayerCharacter>().Health;
                if (collision.transform.GetComponent<PlayerCharacter>().Health <= 0)
                {
                    GameManager.instance.GameOver();
                }
            }
            else
            {
                collision.transform.GetComponent<PlayerCharacter>().Shield-=10;
            }
           
            Destroy(gameObject);

        }
      
    }


    void destruct()
    {
        Destroy(gameObject);
    }
}
