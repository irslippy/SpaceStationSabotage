using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shield : MonoBehaviour
{
    [Header("Shield Stats")]
    public int ShieldMaxHealth = 100;
    public int CurrentHealth;

    public ShieldBar shieldBar;

    [Header("Alternate Version")]
    public GameObject destroyedVersion;

    //Sets shield health to max amount
    void Start()
    {
        CurrentHealth = ShieldMaxHealth;
        shieldBar.SetMaxValue(ShieldMaxHealth);

    }

    //if shield health is zero, broken shield prefab replaces original shield
    private void Update()
    {
        if (CurrentHealth <= 0)
        {
            Instantiate(destroyedVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    //detects collision with turret projectile and applies health reduction
    public void OnTriggerEnter(Collider SpyderBullet)
    {
        if (SpyderBullet.gameObject.tag == "Enemy")
        {
          //  Debug.Log("shield hit");
            TakeDamage(10);

        }

    }
    //reduces health and updates health bar
    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        shieldBar.SetStat(CurrentHealth);
    }



}