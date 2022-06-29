using UnityEngine;

public class Bomba : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("Explotar"))
        {
            Destroy(gameObject);
        }
    }
}
