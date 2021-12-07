using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSFX : MonoBehaviour
{
    //plays random sound effect every time shot is fired
    public AudioClip[] shootSFX;
    public AudioSource source;
    bool shotFired = false;
    // Start is called before the first frame update
    private void Awake()
    {
        source = GetComponent<AudioSource>();
        

    }
    private void OnEnable()
    {
        source.clip = shootSFX[Random.Range(0, shootSFX.Length)];
    }
    void Start()
    {
        if (shotFired == false)
        {
            
            source.PlayOneShot(source.clip);
            shotFired = true;
        }
    }

   
           
    

}
