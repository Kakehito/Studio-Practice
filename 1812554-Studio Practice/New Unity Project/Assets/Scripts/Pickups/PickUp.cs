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
            other.transform.GetComponent<PlayerCharacter>().Health += HealthtoRestore;
            other.transform.GetComponent<PlayerCharacter>().AttackDamage += AttackUp;
            other.transform.GetComponent<PlayerCharacter>().Shield += ShieldUp;
            Destroy(gameObject);
        }
    }
}
