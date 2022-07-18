using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    EnemyManager enemyManagment;
    private void Awake()
    {
        if (GameObject.Find("EnemyManager"))
        {
            GameObject _EnemyManagment = GameObject.Find("EnemyManager");
            enemyManagment = _EnemyManagment.GetComponent<EnemyManager>();
        }
    }

    public void Mori()
    {
        if (enemyManagment != null)
        {
            enemyManagment._EnemyMuertos++;
        }
    }
}
