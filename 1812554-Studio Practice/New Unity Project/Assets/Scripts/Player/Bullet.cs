using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Invoke("destruct", 3);
    }
    
    void Update()
    {
        transform.localPosition += (transform.forward * speed) * Time.deltaTime;
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
