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

    //public AudioSource source;
   // public AudioClip clip;
   bool soundHasPlayed = false;

    private void Awake()
    {
        //source = GetComponent<AudioSource>();
    }

    private void Start()
    {
        //source.clip = clip;
    }

    public void OnTriggerEnter(Collider enemy)
    {
        if (enemy.gameObject.tag == "PlayerProjectile" && soundHasPlayed == false)
        {
            light1.color = newColor;
            light2.color = newColor;
            light3.color = newColor;
            light4.color = newColor;
            light5.color = newColor;

            //source.PlayOneShot(clip);
            //soundHasPlayed = true;

        }

    }
}
