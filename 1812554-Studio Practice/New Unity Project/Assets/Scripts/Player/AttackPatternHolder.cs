using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[SerializeField]
public enum AttackPattern {OneShot,DoubleShot,TripleShot}


public class AttackPatternHolder : MonoBehaviour
{


    
    public Transform[] Shooters_01;
    public Transform[] Shooters_02;
    public Transform[] Shooters_03;



   




   public void UpdateShooter(AttackPattern p)
    {
        if(p == AttackPattern.OneShot)
        {
            foreach(Transform t in Shooters_01)
            {
                t.gameObject.SetActive(true);
            }
            foreach(Transform t in Shooters_02)
            {
                t.gameObject.SetActive(false);
            }
            foreach (Transform t in Shooters_03)
            {
                t.gameObject.SetActive(false);
            }
        }
        else if (p == AttackPattern.DoubleShot)
        {
            foreach (Transform t in Shooters_01)
            {
                t.gameObject.SetActive(false);
            }
            foreach (Transform t in Shooters_02)
            {
                t.gameObject.SetActive(true);
            }
            foreach (Transform t in Shooters_03)
            {
                t.gameObject.SetActive(false);
            }
        }
        else if (p == AttackPattern.TripleShot)
        {
            foreach (Transform t in Shooters_01)
            {
                t.gameObject.SetActive(false);
            }
            foreach (Transform t in Shooters_02)
            {
                t.gameObject.SetActive(false);
            }
            foreach (Transform t in Shooters_03)
            {
                t.gameObject.SetActive(true);
            }
        }
    }
}
