using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;



    private void Start()
    {
        Invoke("destruct", 2);
    }
  
    void Update()
    {
        transform.localPosition += (transform.forward * speed) * Time.deltaTime;
        if (Input.GetButtonDown("Bomb"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            if(collision.transform.GetComponent<PlayerCharacter>().Shield <= 0)
            {
                collision.transform.GetComponent<PlayerCharacter>().Health--;
            }
            else
            {
                collision.transform.GetComponent<PlayerCharacter>().Shield--;
            }
         
        }
        Destroy(gameObject);
    }



    void destruct()
    {
        Destroy(gameObject);
    }
}
