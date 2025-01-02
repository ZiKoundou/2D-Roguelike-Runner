using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Wave;
    public int maxWaveNumber = 5;
    // change this number if u want more variation of waves
    private int waveNumber;
    //this is the current wave number we are on
    public float timer = 0;
    //this is the timer that gets updated each second before spawn rate is called
    public float spawnRate = 5;

    public int waveCount = 0;
    void Start()
    {
        RandomizeWave("normal");
    }

    // Update is called once per frame
    void Update()
{
    if(timer < spawnRate){
        timer += Time.deltaTime;

    }else if (waveCount == 2){
        Instantiate(Wave,transform.position,transform.rotation);
        RandomizeWave("powerup");
        waveCount = 0;
        timer = 0;
        if(spawnRate >= 2.5f){
            spawnRate -= 0.5f;
        }

    } else if (waveCount < 2){
        Instantiate(Wave,transform.position,transform.rotation);
        RandomizeWave("normal");
        waveCount += 1;
        timer = 0;
    }
}

void RandomizeWave(string type){
    if(type == "powerup"){
        waveNumber = Random.Range(1,maxWaveNumber);
        Wave = Resources.Load<GameObject>($"Prefabs/WavePrefabs/Wave p{waveNumber}");
        //put "p" before wave number for the powerup waves
    }else if (type == "normal"){
        waveNumber = Random.Range(1,maxWaveNumber);
        Wave = Resources.Load<GameObject>($"Prefabs/WavePrefabs/Wave {waveNumber}");
    }
    
}
}
