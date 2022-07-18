using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    public int _PointOnKill;
    private ScoreManager scoreManager;
    private void Awake()
    {
        GameObject gameObject = GameObject.Find("ScoreManager");
        scoreManager = gameObject.GetComponent<ScoreManager>();
    }

    public void Mori()
    {
        scoreManager._Score += _PointOnKill;
    }
}
