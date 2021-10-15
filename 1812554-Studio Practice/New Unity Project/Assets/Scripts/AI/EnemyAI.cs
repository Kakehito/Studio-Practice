using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{


    public Animator anim;
    public Transform MovePoint;
    public float Speed;
<<<<<<< HEAD:1812554-Studio Practice/New Unity Project/Assets/Scripts/AI/EnemyMotor.cs

=======
    public int Health;
>>>>>>> main:1812554-Studio Practice/New Unity Project/Assets/Scripts/AI/EnemyAI.cs
    private void Start()
    {
 
        MovePoint.parent = null;
      //  anim = MovePoint.GetComponent<Animator>();
    }

    private void Update()
    {


        transform.position = Vector3.MoveTowards(transform.position, MovePoint.position, Time.deltaTime * Speed);




        if(Health <= 0)
        {
            Destroy(gameObject);
        }
        if (Vector3.Distance(transform.position, MovePoint.position) <= .5f)
        {
            anim.enabled = true;
        }
        else
        {
            anim.enabled = false;
        }
     

          

    }




}
