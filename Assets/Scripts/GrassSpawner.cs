using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float t = 0;

    void Update()
    {
        t = t + Time.deltaTime;
        if (t >= 0.5)
        {
            GameObject copy = Instantiate (prefab, transform.position, Quaternion.identity);
            Destroy (copy, 10);
            t = 0;
        }
    }
}
