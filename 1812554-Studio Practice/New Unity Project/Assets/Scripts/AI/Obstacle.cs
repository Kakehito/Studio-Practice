using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Transform player;
    PlayerCharacter character;
    public float range;

    Health healthpoints;

    private void Start()
    {
        player = GameManager.instance.PlayerCharacter;
        character = player.GetComponent<PlayerCharacter>();
        healthpoints = player.GetComponent<Health>();
    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance <= range)
        {
            GameManager.instance.GameOver();
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
