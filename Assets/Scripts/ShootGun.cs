using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    
    public GameObject projectile;
    public GameObject launchPosition;
    public float power;
    
    void LaunchProjectile()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(launchPosition.transform.forward * power, ForceMode.VelocityChange);
    }
}
