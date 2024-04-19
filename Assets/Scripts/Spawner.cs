using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float t = 0;

    // Update is called once per frame
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
