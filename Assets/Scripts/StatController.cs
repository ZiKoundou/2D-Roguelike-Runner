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
    private float shotSpeed;
    private float damage;
    private UnityEngine.Vector3 playerSize;
    private UnityEngine.Vector3 shotSize;
    private float defense;
    private float vitality;
    private float lifesteal;


    public float GetHealth(){
        return currentHealth;
    }

    
    public float GetMaxHealth(){
        return maxHealth;
    }

    public float GetMoveSpeed(){
        return moveSpeed;
    }
    public float GetshotRate(){
        return shotRate;
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

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
