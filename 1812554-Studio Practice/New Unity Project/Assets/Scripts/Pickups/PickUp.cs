using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public int HealthtoRestore = 0;
    public int AttackUp = 0;
    public int ShieldUp = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            other.transform.GetComponent<PlayerMovement>().Health += HealthtoRestore;
            other.transform.GetComponent<PlayerMovement>().AttackDamage += AttackUp;
            other.transform.GetComponent<PlayerMovement>().Shield += ShieldUp;
            Destroy(gameObject);
        }
    }
}
