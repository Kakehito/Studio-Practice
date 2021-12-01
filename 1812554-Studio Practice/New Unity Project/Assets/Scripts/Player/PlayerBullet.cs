using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{

    Rigidbody RB;

    private void Start()
    {
        RB = GetComponent<Rigidbody>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    void FixedUpdate()
    {
        RB.velocity = transform.forward * Time.deltaTime * 7;
    }


}
