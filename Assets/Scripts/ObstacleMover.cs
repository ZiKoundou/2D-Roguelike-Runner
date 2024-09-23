using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{   
    
    public float moveSpeed = 2;
    public float deadZone = -7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position +(Vector3.down*moveSpeed)*Time.deltaTime;
        if(transform.position.y < deadZone){
            Destroy(gameObject);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Bullet"){
            Destroy(collision.gameObject);
            
        }
    }
}
