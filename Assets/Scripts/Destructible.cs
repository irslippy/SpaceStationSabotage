using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersion;
    

    
    //detects collision of player projectile on turret and destroys turret
    public void OnTriggerEnter(Collider enemy)
    {
        if (enemy.gameObject.tag == "PlayerProjectile")
        {
            DestroyEnemy();
           
        }

    }

    public void DestroyEnemy()
    {
       // Debug.Log("enemy destroyed");
        //instantly replaces existing turret with destroyed variant that falls to pieces when destroyed
        Instantiate(destroyedVersion, transform.position, transform.rotation);
        Destroy(gameObject);

    }

    
}
