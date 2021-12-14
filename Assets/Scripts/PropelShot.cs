using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropelShot : MonoBehaviour
{
    public float shotVelocity;
    void Start()
    {

        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddRelativeForce(gameObject.transform.forward * shotVelocity, ForceMode.VelocityChange);

    }

    private void OnCollisionEnter(Collision collision)
    {
       Destroy(gameObject);
    }
}
