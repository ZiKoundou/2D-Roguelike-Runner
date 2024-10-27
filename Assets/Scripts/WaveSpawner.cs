using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Wave;
    public int maxWaveNumber = 5;
    private int waveNumber;
    public float timer = 0;
    public float spawnRate = 5;
    void Start()
    {
        RandomizeWave();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate){
            timer += Time.deltaTime;
        }else{
            
            Instantiate(Wave,transform.position,transform.rotation);
            RandomizeWave();
            timer = 0;
        }
    }

    void RandomizeWave(){
        waveNumber = Random.Range(1,maxWaveNumber);
        Wave = Resources.Load<GameObject>($"Prefabs/WavePrefabs/Wave {waveNumber}");
    }
}
