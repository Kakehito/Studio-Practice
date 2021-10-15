using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed; 

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += new Vector3(0, 0, (transform.localPosition.z + speed) * Time.deltaTime);
    }
}
