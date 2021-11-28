using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayer : MonoBehaviour
{
    //detects player within attack zone
    bool detected;
    GameObject target;
    public Transform enemy;

    public Vector3 currentRotation;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (detected)
        {
            enemy.LookAt(target.transform);
            currentRotation = new Vector3(currentRotation.x, currentRotation.y, currentRotation.z % 360f);
            this.transform.eulerAngles = currentRotation;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            detected = true;
            target = other.gameObject;
        }
    }


    
}
