using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveDespawner : MonoBehaviour
{
    public float baseSpeed;
    public float deadzone = -7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position +(Vector3.down*baseSpeed*Gamemanager.Instance.Difficulty)*Time.deltaTime;
        if(transform.position.y < deadzone){
            Destroy(gameObject);
        }
    }
}
