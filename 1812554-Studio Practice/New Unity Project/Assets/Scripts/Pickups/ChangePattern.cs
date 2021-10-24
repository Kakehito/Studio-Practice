using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePattern : MonoBehaviour
{

    public AttackPattern patern;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<AttackPatternHolder>().UpdateShooter(patern);
            Destroy(gameObject);
        }
    }



}
