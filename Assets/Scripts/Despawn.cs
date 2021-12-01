using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    [Header("Time in seconds")]
    public float despawnTime = 2.0f; //This implies a delay of 2 seconds.

    private void Start()
    {
        despawnTime = Time.deltaTime;
        if (despawnTime >= 0)
        {
            Destroy(gameObject);
        }
    }
}
