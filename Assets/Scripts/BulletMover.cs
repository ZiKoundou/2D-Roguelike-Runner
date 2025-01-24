using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMover : MonoBehaviour
{
    private float shotSpeed;
    //public float damage = 1f;
    private float lifetime = 5;
    private float damage;
    
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    public void SetDamage(float Damage){
        damage = Damage;
    }
    public void SetShotSpeed(float ShotSpeed){
        shotSpeed = ShotSpeed;
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position += (Vector3.up*shotSpeed)*Time.deltaTime;
        timer += Time.deltaTime;
        //Debug.Log(timer);
        if(timer >= lifetime){
            //Debug.Log("destroy");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        //Debug.Log(damage);
        EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if(collision.gameObject.tag == "Enemy"){
            enemyHealth.takeDamage(damage);
            Destroy(gameObject);    
        }
    }
}
