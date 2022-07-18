using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorOleada : MonoBehaviour
{
    public GameObject prefab;
    public float _TimeToSpawn;
    public float _StartSpawn;
    private void Awake()
    {
        InvokeRepeating("InstanciarPrefab", _StartSpawn, _TimeToSpawn);
    }

    void InstanciarPrefab()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
