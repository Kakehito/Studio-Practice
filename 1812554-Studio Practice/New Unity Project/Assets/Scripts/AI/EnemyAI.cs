using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{


    Animator anim;
 

    public Transform MovePoint;
    public float Speed;
  

    private void Start()
    {
   
        MovePoint.parent = null;
        anim = MovePoint.GetComponent<Animator>();
    }

    private void Update()
    {


        transform.position = Vector3.MoveTowards(transform.position, MovePoint.position, Time.deltaTime * Speed);


        
       
        if (Vector3.Distance(transform.position, MovePoint.position) <= .1f)
        {
            anim.enabled = true;
          

        }
        else
        {
     
            anim.enabled = false;
        }

   


    }


  

}
