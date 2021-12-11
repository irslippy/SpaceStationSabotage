using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alarmLights : MonoBehaviour
{
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public Light light5;

    public Color newColor;

   
    public void OnTriggerEnter(Collider enemy)
    {
        if (enemy.gameObject.tag == "PlayerProjectile")
        {
            light1.color = newColor;
            light2.color = newColor;
            light3.color = newColor;
            light4.color = newColor;
            light5.color = newColor;


        }

    }
}
