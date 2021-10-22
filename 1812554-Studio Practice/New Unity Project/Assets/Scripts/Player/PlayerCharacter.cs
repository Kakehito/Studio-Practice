using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    
    CharacterController controller;

    public float speed = 6f;
    public int Health = 3;
    public int AttackDamage = 1;
    public int Shield = 0;
    public int Bombs = 0;

    public Image bombBar;
    public Image[] bombCounter;

    float bombs, maxBombs = 3;
    float lerpSpeed;

    private void Start()
    {
        bombs = maxBombs;
        controller = GetComponent<CharacterController>();
    }    
    
    void Update()
    {
        #region Movement
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }

        #endregion

        #region Bombs
        if (bombs > maxBombs) bombs = maxBombs;

        lerpSpeed = 3f * Time.deltaTime;

        BombFiller();
        if (Input.GetButtonDown("Bomb"))
        {
            BombFire(1);
        }
        #endregion
    }   

    void BombFiller()
    {
        bombBar.fillAmount = Mathf.Lerp(bombBar.fillAmount, bombs / maxBombs, lerpSpeed);

        for(int i = 0; i < bombCounter.Length; i++)
        {
            bombCounter[i].enabled = !DisplayBombNumber(bombs, i);
        }
    }

    bool DisplayBombNumber(float _bombs, int pointNumber)
    {
        return ((pointNumber) >= _bombs);
    }

    public void BombFire(float usedBomb)
    {
        if (bombs > 0)
            bombs -= usedBomb;
    }

    public void BombPickUp(float pickedBomb)
    {
        if (bombs < maxBombs)
            bombs += pickedBomb;
    }
}
