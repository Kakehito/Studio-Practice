using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager instance;
    GameManager()
    {
        instance = this;
    }
    #endregion

    public Transform PlayerCharacter;

}
