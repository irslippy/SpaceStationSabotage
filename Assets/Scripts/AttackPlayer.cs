using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{
    //detects player within attack zone
    bool detected;
    GameObject target;
   

    //point of which the turret rotates around
    public Transform pivotPoint;

    //turret bullet
    public GameObject turretProjectile;

    //location of spawnpoint for bullet
    public Transform projectileSpawner;

    // turret bullet variables
    public float shotVelocity = 10f;
    public float timeBetweenShots = 1.3f;
    float originalTime;
    public Vector3 currentRotation;

    //sounds
    [Header("SFX")]
    public AudioSource source;
    public AudioClip[] SFXArray;
    private bool sfxHasPlayed = false;
    
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    //resets timeBetweenShots to desired value
    private void Start()
    {
        source.clip = SFXArray[Random.Range(0, SFXArray.Length)];
        originalTime = timeBetweenShots;
        Physics.IgnoreLayerCollision(7, 6);
    }

    // turret rotates to face player once player is in range
    void Update()
    {
        if (detected)
        {

            pivotPoint.LookAt(target.transform);
            currentRotation = new Vector3(currentRotation.x, currentRotation.y, currentRotation.z % 360f);
            this.transform.eulerAngles = currentRotation;

            timeBetweenShots -= Time.deltaTime;

            if (timeBetweenShots < 0)
            {
                ShootPlayer();
                timeBetweenShots = originalTime;
            }

        }     
    }
    //detects if player is within range of turret [engage attack mode]
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            detected = true;
            target = other.gameObject;

            //plays random audio clip once on entry
            if (sfxHasPlayed == false)
            {
                source.PlayOneShot(source.clip);
                sfxHasPlayed = true;
            }
        }
    }

    //detects if player has left range [engage passive mode]
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            detected = false;
            target = other.gameObject;          
        }
    }

    // spawns turret bullet and adds force
    private void ShootPlayer()
    {
        GameObject currentBullet = Instantiate(turretProjectile, projectileSpawner.position, projectileSpawner.rotation);
        Rigidbody rb = currentBullet.GetComponent<Rigidbody>();
        rb.AddRelativeForce(projectileSpawner.transform.forward * shotVelocity, ForceMode.VelocityChange);
        
    }

}
