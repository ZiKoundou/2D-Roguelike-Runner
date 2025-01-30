using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WaveSpawner : MonoBehaviour{
    // Start is called before the first frame update
    public GameObject Wave;
    public WaveDespawner waveDespawner;
    public GameObject[] normalWaves;
    public GameObject[] specialWaves;

    //public int maxWaveNumber = 5;
    // change this number if u want more variation of waves
    
    //this is the current wave number we are on
    //public int waveCount;
    
    //this is the timer that gets updated each second before spawn rate is called
    private int waveNumber;
    public float baseSpawnRate = 5f;
    public float currentSpawnRate;

    private float decayRate = 0.0025f;
    
    private float timer = 0;
    private float timeSinceLastSpawn;
    [SerializeField]
    private float minimumSpawnrate;
    void Start()
    {
        currentSpawnRate = baseSpawnRate;
        timer = 0;
        timeSinceLastSpawn = 0;
        waveNumber = 1;
        minimumSpawnrate = 0.5f;
    }

    // Update is called once per frame
    void Update(){
        timeSinceLastSpawn += Time.deltaTime;
        
        if (timeSinceLastSpawn >= currentSpawnRate){
            SpawnWave();
            timeSinceLastSpawn = 0;
            timer += currentSpawnRate;
            currentSpawnRate = baseSpawnRate*Mathf.Exp(-decayRate * timer);
            currentSpawnRate = Mathf.Max(currentSpawnRate, minimumSpawnrate);
            waveNumber++;
        }
    }

    void SpawnWave(){
        GameObject waveToSpawn;
        //if third wave spawn a special wave
        if (waveNumber % 3 == 0){
            waveToSpawn = specialWaves[UnityEngine.Random.Range(0, specialWaves.Length)];
        }else{
            waveToSpawn = normalWaves[UnityEngine.Random.Range(0, normalWaves.Length)];
        }
        Instantiate(waveToSpawn, transform.position, Quaternion.identity);
    }



}