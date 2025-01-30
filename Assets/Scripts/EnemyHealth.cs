using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public GameObject FloatingTextPrefab;
   
    public float Health;
    public float maxHealth;
    public float baseHealth = 1;
    public Healthbar healthbar;

    
    //[SerializeField]private GameObject currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponentInChildren<Healthbar>();
        maxHealth = baseHealth * Gamemanager.Instance.Difficulty; 
        Health = maxHealth;
        healthbar.UpdateHealthBar(Health, maxHealth);
        
        //currentHealth = GetComponentInChildren<GameObject>();
    }
    void ShowFloatingText(float damageAmount){

        var go = Instantiate(FloatingTextPrefab,transform.position,Quaternion.identity);
        go.GetComponent<TextMeshPro>().text = "-" + damageAmount.ToString();
    }

    public void takeDamage(float damageAmount){
        //currentHealth.gameObject.SetActive(true);
        Health -= damageAmount;
        healthbar.UpdateHealthBar(Health, maxHealth);
        //show dmg text
        if(FloatingTextPrefab){
            ShowFloatingText(damageAmount);
        }   
        
        if(Health <= 0){
            Destroy(gameObject);
        }
    }

    // private void OnCollisionEnter2D(Collision2D collision){
    //     if (collision.gameObject.tag == "Bullet"){
    //         takeDamage(collision.gameObject.damage);
    //         Destroy(collision.gameObject);
            
    //     }
    // }

}
