using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawner : MonoBehaviour
{
    public GameObject powerup;
    public float spawnRate = 25;
    public float timer = 0;
    public float lengthOffset = 5;
    void Start()
    {
        //spawnPowerup();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer += Time.deltaTime;
        } else{
            spawnPowerup();
            timer = 0;
        }
    }
    void spawnPowerup(){
        float leftPoint = transform.position.x - lengthOffset;
        float rightPoint = transform.position.x + lengthOffset;
        Instantiate(powerup,new Vector3(Random.Range(leftPoint, rightPoint),transform.position.y),transform.rotation);
    }
}
