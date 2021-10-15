using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += new Vector3(0, 0, (transform.localPosition.z + speed) * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            if(collision.transform.GetComponent<PlayerMovement>().Shield <= 0)
            {
                collision.transform.GetComponent<PlayerMovement>().Health--;
            }
            else
            {
                collision.transform.GetComponent<PlayerMovement>().Shield--;
            }
         
        }
        Destroy(gameObject);
    }
}
