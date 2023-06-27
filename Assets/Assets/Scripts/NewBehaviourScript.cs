using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);
        int x = 0;

        //flip player left/right
        if (horizontalInput > -.01f){
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < .01f){
            transform.localScale = new Vector3(-1,1,1);
        }


        if (Input.GetKey(KeyCode.Mouse0)){
            x = 1;
        }

        //set animator parameters
        anim.SetBool("Walk", horizontalInput != 0);
        anim.SetBool("mouse", x != 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
