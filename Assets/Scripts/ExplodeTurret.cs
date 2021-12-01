using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeTurret : MonoBehaviour
{
    public GameObject TurretPowerCell;
    [Header("Visual effect")]
    public GameObject explosionEffect;
    [Header("Explosion Variables")]
    public float blastRadius;
    public float explosionForce = 700f;
    public float upForce = 1.0f;
    private bool hasExploded = false;
    
    void Start()
    {
        //detonate called in start because object containing Detonate() function
        //is instantiated at the precise moment that the player's projectile connects with 
        //turrets hitbox. Also ensures that the turret
        //wont repeadately explode by using hasExploded bool.
        if (TurretPowerCell == enabled && hasExploded == false)
        {
            Detonate();
            hasExploded = true;
        }
        
    }
    
    void Detonate()
    {
        //defines location of explosion
        Vector3 explosionPosition = TurretPowerCell.transform.position;

        //creates an array that populates with colliders within explosion radius
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, blastRadius);
        //applies explosion effect to all objects within radius that are rigidbodies
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, explosionPosition, blastRadius, upForce, ForceMode.Impulse);

            }
        }
        Destroy(gameObject);
    }

}
