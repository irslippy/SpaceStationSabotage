using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmSystem : MonoBehaviour
{
   
    private void Start()
    {
        
       
    }


    //detects collision of player projectile on turret and destroys turret
    public void OnTriggerEnter(Collider enemy)
    {
        if (enemy.gameObject.tag == "PlayerProjectile")
        {
             

        }

    }

    


}

