using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    private float Health;
    private float maxHealth;
    [SerializeField]statController statController;
    [SerializeField] PlayerHealthbar healthbar;
    
    void Start(){
        // Ensure statController is assigned
        CheckStatController();

    }
    void Update()
    {
        Health = statController.GetHealth();
        maxHealth = statController.GetMaxHealth();
        healthbar.UpdateHealthBar(Health, maxHealth);
        //healthbar = GetComponentInChildren<Healthbar>();
    }

    public void takeDamage(float damageAmount){
        //health.gameObject.SetActive(true);
        Health -= damageAmount;
        statController.SetHealth(Health);
        healthbar.UpdateHealthBar(Health, maxHealth);
        if(Health <= 0){
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Enemy"){
            Destroy(collision.gameObject);
            takeDamage(1f);
        }
    }
    void CheckStatController(){
        if (statController == null)
        {
            statController = GetComponentInParent<statController>();
            if (statController == null)
            {
                Debug.LogError("statController not found on parent!");
                return;
            }
        }
    }

    void ResetHealth(){
        maxHealth = statController.GetMaxHealth();
        Health = maxHealth;
        statController.SetHealth(Health);
    }

    void CheckHealthBar(){
        if (healthbar != null)
        {
            healthbar.UpdateHealthBar(Health, maxHealth);
        }
        else
        {
            Debug.LogWarning("Healthbar reference not assigned in PlayerHealth.");
        }
    }

}
