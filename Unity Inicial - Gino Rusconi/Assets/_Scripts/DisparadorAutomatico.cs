using UnityEngine;

public class DisparadorAutomatico : MonoBehaviour
{
    public GameObject prefab;

    void Awake()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
