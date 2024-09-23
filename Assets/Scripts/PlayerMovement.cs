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
    private bool isFacingRight = true;
    Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
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

    public void Move(InputAction.CallbackContext context){
        horizontal = context.ReadValue<Vector2>().x;

        playerAnimator.SetBool("isRunning", true);
        
    }
}   
