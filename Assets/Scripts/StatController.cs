using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class statController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float moveSpeed, maxHealth,  shotRate;
    //not in player script
    private float currentHealth;
    [SerializeField]
    private float damage, shotSpeed;
    private UnityEngine.Vector3 playerSize;
    private UnityEngine.Vector3 shotSize;
    private float defense;
    private float vitality;
    private float lifesteal;
    private float critChance;


    public float GetHealth(){
        return currentHealth;
    }

    
    public float GetMaxHealth(){
        return maxHealth;
    }
    public float GetDamage(){
        return damage;
    }
    public float GetMoveSpeed(){
        return moveSpeed;
    }
    public float GetShotRate(){
        return shotRate;
    }
    public float GetShotSpeed(){
        return shotSpeed;
    }
    public void SetMoveSpeed(float newSpeed)            {
        moveSpeed = newSpeed;
    }

    public void SetHealth(float health){
        currentHealth = health;
        if(currentHealth >= maxHealth){
            currentHealth = maxHealth;
        }
    }

    public void SetMaxHealth(float health){
        maxHealth = health;
        
    }

    public void SetDamage(float Damage){
        damage = Damage;
    }

    public void SetShotSpeed(float ShotSpeed){
        shotSpeed = ShotSpeed;
    }
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
