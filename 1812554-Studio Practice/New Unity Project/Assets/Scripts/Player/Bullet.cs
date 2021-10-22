using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Invoke("destruct", 2);
    }
    
    void Update()
    {
        transform.localPosition += (transform.forward * speed) * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Enemy")
        {
            collision.transform.GetComponent<EnemyAI>().Health--;
        }
        Destroy(gameObject);
    }

    void destruct()
    {
        Destroy(gameObject);
    }
}
