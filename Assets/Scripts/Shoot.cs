using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    Animator playerAnimator;
    public Transform shootingPoint;
    public GameObject bullet;

    statController statController;
    float shotRate;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = gameObject.GetComponent<Animator>();
        statController  = GetComponentInParent<statController>();
    }

    // Update is called once per frame
    void Update()
    {
        shotRate = statController.GetshotRate();
        if(Input.GetKey(KeyCode.Mouse0) && timer<=0 && playerAnimator.GetBool("isShooting") == false){
            
            shoot();
            timer = shotRate;
            
        } else{
            
            //playerAnimator.SetBool("isShooting", false);
            timer -= Time.deltaTime;
        }
        
    }
    void shoot(){
        float playerDamage = statController.GetDamage();
        playerAnimator.SetBool("isShooting", true);
        GameObject instantiatedBullet = Instantiate(bullet, shootingPoint.position,transform.rotation);
        instantiatedBullet.GetComponent<BulletMover>().SetDamage(playerDamage);
    }
    void resetShot(){
        playerAnimator.SetBool("isShooting", false);
    }
}
