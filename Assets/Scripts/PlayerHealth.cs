using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public float Health;
    public float maxHealth;
    [SerializeField] PlayerHealthbar healthbar;
    void Update()
    {
        healthbar.UpdateHealthBar(Health, maxHealth);
        //healthbar = GetComponentInChildren<Healthbar>();
    }

    public void takeDamage(float damageAmount){
        //health.gameObject.SetActive(true);
        Health -= damageAmount;
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
}
