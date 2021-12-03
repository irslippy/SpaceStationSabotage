using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [Header("Player Stats")]
    public int PlayerMaxHealth = 100;
    public int CurrentHealth;
    public HealthBar healthBar;
    public Transform playerCamera;


    [Header("On Death")]
    public GameObject deathMessage;
    public GameObject deathTablet;
    
    public GameObject DeathUI;
    public GameObject DeathUILocation;

    //Sets player health to max amount
    void Start()
    {
        deathMessage.SetActive(false);
        deathTablet.SetActive(false);

        CurrentHealth = PlayerMaxHealth;
        healthBar.SetMaxValue(PlayerMaxHealth);

    }

    //if player health is zero, game is paused and Death UI appears
    private void Update()
    {
        if (CurrentHealth <= 0)
        {
            deathMessage.SetActive(true);
            deathTablet.SetActive(true);
          
            

            //this pauses the game giving the player the chance to interact with the UI
            PauseGame();
        }
    }
    //detects collision with turret projectile and applies health reduction
    public void OnTriggerEnter(Collider SpyderBullet)
    {
        if (SpyderBullet.gameObject.tag == "Enemy")
        {
            //Debug.Log("player hit");
            TakeDamage(20);
        }

    }

    void PauseGame()
    {
        Time.timeScale = 0;
        Instantiate(DeathUI, DeathUILocation.transform.position, DeathUILocation.transform.rotation);
        //  deathTablet.LookAt(playerCamera.transform);      (FIX LATER)
    }
    //reduces health and updates health bar
    void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        healthBar.SetStat(CurrentHealth);
    }
}
