using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible_Legs : MonoBehaviour
{
    public GameObject destroyedVersion1;
    public GameObject destroyedVersion2;
    public GameObject destroyedVersion3;
    public GameObject destroyedVersion4;
    private void OnMouseDown()
    {
        
        Instantiate(destroyedVersion1, transform.position, transform.rotation);
        Instantiate(destroyedVersion2, transform.position, transform.rotation);
        Instantiate(destroyedVersion3, transform.position, transform.rotation);
        Instantiate(destroyedVersion4, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
