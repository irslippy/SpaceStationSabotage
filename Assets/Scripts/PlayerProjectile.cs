using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerProjectile : MonoBehaviour
{
    public GameObject shootPoint;
    public float velocity;
    

    private void Start()
    {
        
     Rigidbody rb = GetComponent<Rigidbody>();
     rb.AddRelativeForce(-shootPoint.transform.forward * velocity, ForceMode.VelocityChange);
        

    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


}
