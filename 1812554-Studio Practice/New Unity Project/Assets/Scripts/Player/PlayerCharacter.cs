using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 6f;
    public int Health = 3;
    public int AttackDamage = 1;
    public int Shield = 0;
    public int Bombs = 0;
    // Update is called once per frame
    void Update()
    {


        #region Movement
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }

        #endregion


        if (Input.GetButtonDown("Bomb"))
        {
            Bomb();
        }

    }


    void Bomb()
    {

    }
}
