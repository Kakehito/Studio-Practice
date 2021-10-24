using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[SerializeField]
public enum AttackPattern {OneShot,DoubleShot,TripleShot}


public class AttackPatternHolder : MonoBehaviour
{    
    public Transform Shooters_01;
    public Transform Shooters_02;
    public Transform Shooters_03;

   public void UpdateShooter(AttackPattern p)
    {
        if(p == AttackPattern.OneShot)
        {
            Shooters_01.gameObject.SetActive(true);
            Shooters_02.gameObject.SetActive(false);
            Shooters_03.gameObject.SetActive(false);
        }
        else if (p == AttackPattern.DoubleShot)
        {
            Shooters_01.gameObject.SetActive(false);
            Shooters_02.gameObject.SetActive(true);
            Shooters_03.gameObject.SetActive(false);
        }
        else if (p == AttackPattern.TripleShot)
        {
            Shooters_01.gameObject.SetActive(false);
            Shooters_02.gameObject.SetActive(false);
            Shooters_03.gameObject.SetActive(true);
        }
    }
}
