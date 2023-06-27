using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      anim = GetComponent<Animator>();
      float horizontal = Input.GetAxis("Horizontal");
      //float vertical = Input.GetAxis("Vertical");

      //Debug.Log(horizontal);
      Vector2 position = transform.position;
      position.x = position.x + 3.0f * horizontal * Time.deltaTime;
      //position.y = position.y + 3.0f * vertical * Time.deltaTime;
      transform.position = position;

      anim.SetBool("Walk", horizontal != 0);
    }
}
