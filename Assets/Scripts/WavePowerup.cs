using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavePowerup : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] powerUpPrefabs;
    void Start(){
        AddPowerUpsToWave(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void AddPowerUpsToWave(GameObject waveInstance){
        // Find all power-up placeholders in the wave using the PowerUp tag
        GameObject[] powerUpPlaceholders = GameObject.FindGameObjectsWithTag("PowerUp");

        // Loop through each placeholder and replace it with a random power-up
        foreach (GameObject placeholder in powerUpPlaceholders)
        {
            // Randomly select a power-up from the array
            GameObject randomPowerUp = powerUpPrefabs[Random.Range(0, powerUpPrefabs.Length)];

            // Get the position of the placeholder
            Vector3 position = placeholder.transform.position;

            // Destroy the placeholder
            Destroy(placeholder);

            // Instantiate the randomly selected power-up at the placeholder's position
            Instantiate(randomPowerUp, position, Quaternion.identity, waveInstance.transform);
        }
    }
}
    
    
