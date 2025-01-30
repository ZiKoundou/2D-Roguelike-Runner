using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    public static Gamemanager Instance;
    public float Difficulty;
    public float DifficultyScaler;
    void Start()
    {
        
    }
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }


    // Update is called once per frame
    private void Update()
    {
        // Increase speed over time (adjust values as needed)
        Difficulty += Time.deltaTime * DifficultyScaler; 
    }
}
