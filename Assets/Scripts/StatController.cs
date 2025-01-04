using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class statController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float moveSpeed, maxHealth, currentHealth, shotRate;
    //not in player script
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

    public float GetMoveSpeed(){
        return moveSpeed;
    }

    public void SetMoveSpeed(float newSpeed)            {
        moveSpeed = newSpeed;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
