using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotor : MonoBehaviour
{

    Transform _transform;
    Animator anim;
    public Transform MovePoint;
    public float Speed;

    private void Start()
    {
        _transform = transform;
        MovePoint.parent = null;
        anim = MovePoint.GetComponent<Animator>();
    }

    private void Update()
    {
        _transform.position = Vector3.MoveTowards(_transform.position, MovePoint.position, Time.deltaTime * Speed);


      if(Vector3.Distance(_transform.position,MovePoint.position) < 0.2f)
        {
            anim.enabled = true;
        }
        else
        {
            anim.enabled = false;
        }
    }




}
