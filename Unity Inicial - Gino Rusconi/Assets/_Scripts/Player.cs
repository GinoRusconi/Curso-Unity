using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameObject _GameManager;
    public bool _PlayerIsDead;
    private void Awake()
    {
        _PlayerIsDead = false;
    }

    public void Mori()
    {
        _PlayerIsDead=true;
    }
}
