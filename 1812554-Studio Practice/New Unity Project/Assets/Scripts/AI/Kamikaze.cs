using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamikaze : MonoBehaviour
{

    public float MovementSpeed;
    public int Damage;

    Transform Player;

    public float range;


    private void Start()
    {
        Player = GameManager.instance.PlayerCharacter;

    }

    private void Update()
    {
        //Lerps the enemy to player position at a constant speed
        transform.position = Vector3.Lerp(transform.position, Player.position, (MovementSpeed * Time.deltaTime) / Vector3.Distance(transform.position, Player.position));
        float distance = Vector3.Distance(transform.position, Player.position);
        if (distance <= range)
        {
            GameManager.instance.GameOver();
        }
    }   
}
