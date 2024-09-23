using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnRate = 2;
    public float timer = 0;
    public float lengthOffset = 3;
    // Start is called before the first frame update
    void Start()
    {
        //spawnObstacle();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timer < spawnRate){
            timer = timer + Time.deltaTime;
        } else{
            spawnObstacle();
            timer = 0;
        }
        
    }
    void spawnObstacle(){
        float leftPoint = transform.position.x - lengthOffset;
        float rightPoint = transform.position.x + lengthOffset;
        Instantiate(obstacle, new Vector3(Random.Range(leftPoint, rightPoint),transform.position.y), transform.rotation);
    }
}
