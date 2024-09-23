using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public float spawnRate = 2;
    public float timer = 0;
    public float lengthOffset = 5;
    void Start()
    {
        spawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate){
            timer += Time.deltaTime;
        } else{
            spawnEnemy();
            timer = 0;
        }
    }
    void spawnEnemy(){
        float leftPoint = transform.position.x - lengthOffset;
        float rightPoint = transform.position.x + lengthOffset;
        Instantiate(enemy,new Vector3(Random.Range(leftPoint, rightPoint),transform.position.y),transform.rotation);
    }
}
