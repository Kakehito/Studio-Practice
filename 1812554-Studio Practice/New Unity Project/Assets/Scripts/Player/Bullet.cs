using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
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
    }








    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            collision.transform.GetComponent<EnemyLife>().Health--;
        }
        Destroy(gameObject);
    }

    void destruct()
    {
        Destroy(gameObject);
    }
}
