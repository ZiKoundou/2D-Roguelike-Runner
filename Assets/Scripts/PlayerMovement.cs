using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float horizontal;
    public float speed = 8f;
    //public float damage = 1f;
    private bool isFacingRight = true;
    
    public float recoveryForce = 2;
    public  float centerYPosition = -4;
    public float yTolerance = 0.5f;
    Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(OffCenter()){
            rb.AddForce(new Vector3(0,1,0) * recoveryForce, ForceMode2D.Force);
        }
        rb.velocity = new Vector2(horizontal* speed,0f);
        //playerAnimator.speed = speed/5;
        if(!isFacingRight && horizontal > 0f){
            Flip();
        } else if(isFacingRight && horizontal < 0f){
            Flip();
        }
        if(horizontal == 0){
            playerAnimator.SetBool("isRunning", false);
        }
        
    }

    private void Flip(){
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    private bool OffCenter(){
        return transform.position.y < centerYPosition;
    }
    public void Move(InputAction.CallbackContext context){
        horizontal = context.ReadValue<Vector2>().x;

        playerAnimator.SetBool("isRunning", true);
        
    }
}   
