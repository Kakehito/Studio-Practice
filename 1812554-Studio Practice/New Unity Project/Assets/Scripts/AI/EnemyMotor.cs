using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMotor : MonoBehaviour
{

    Transform _transform;
    public Transform MovePoint;
    public float Speed;
    private void Start()
    {
        _transform = transform;
    }
    private void Update()
    {
        _transform.position = Vector3.MoveTowards(_transform.position, MovePoint.position, Time.deltaTime * Speed);
    }

}
