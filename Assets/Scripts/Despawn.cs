using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    [Header("Time in seconds")]
    public float timeRemaining = 10; //implies a countdown of seconds until despawn

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
