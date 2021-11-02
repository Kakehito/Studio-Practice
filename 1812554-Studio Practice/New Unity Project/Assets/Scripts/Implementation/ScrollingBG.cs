using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    public float Speed;


    private void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (Speed * Time.deltaTime));
    }



}
