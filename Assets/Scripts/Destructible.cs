using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersion;
    void OnMouseDown ()
    {
        Debug.Log("clicked");
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}

