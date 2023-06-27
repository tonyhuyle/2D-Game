using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask wallLayer;
    private Rigidbody2D body;
    private Animator anim;
    //private bool grounded;
    //private BoxCollider2D boxCollider;
    //private float wallJumpCooldown;
    private float horizontalInput;

    private void Awake()
    {
        // Grab references for rigidbody and animator from object
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update(){
        float horizontalInput = Input.GetAxis("Horizontal");

        // Flip player when moving left-right
        if(horizontalInput > -0.01f)
            transform.localScale = new Vector3(0.8762676f,0.7580417f,1);
        else if(horizontalInput < 0.01f)
            transform.localScale = new Vector3(-0.8762676f, 0.7580417f, 1);
    }

    public bool canAttack()
    {
        return horizontalInput == 0; 
    }
}
