using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class InGameUI : MonoBehaviour
{

    public Slider healthbar;
    public Text BombCounter;


    GameManager World;
    PlayerMovement Player;
    private void Start()
    {
        World = GameManager.instance;
        Player = World.PlayerCharacter.GetComponent<PlayerMovement>();
    }


    private void FixedUpdate()
    {
        healthbar.value = Player.Health;
        BombCounter.text = Convert.ToString(Player.Bombs);
    }


}
