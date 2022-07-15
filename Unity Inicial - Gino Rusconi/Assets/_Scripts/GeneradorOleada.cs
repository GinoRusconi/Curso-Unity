using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorOleada : MonoBehaviour
{
    public GameObject prefab;
    public float _TimeToSpawn;
    private void Awake()
    {
        InvokeRepeating("InstanciarPrefab", 0.2f, _TimeToSpawn);
    }

    void InstanciarPrefab()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
