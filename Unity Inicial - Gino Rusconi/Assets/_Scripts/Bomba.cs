using UnityEngine;

public class Bomba : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Explotar"))
        {
            Destroy(gameObject);
        }
    }
}
