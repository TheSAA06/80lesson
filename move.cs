using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;
    float v;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        v = Input.GetAxis("Vertical");
        rb.velocity = transform.forward * v * 5f;
        if(v!=0)
        {
            anim.SetBool("isWalk", true);
        }else
        {
            anim.SetBool("isWalk", false);
        }
        if(Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger("attack");
        }
    }
}
