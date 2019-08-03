using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    bool moving;
    Animator anim;
    Rigidbody2D r2b;
    bool jumping;

    private void Awake() {
        anim = GetComponent<Animator>();
        r2b = GetComponent<Rigidbody2D>();
    }

    void setSpeed()
    {
        moving = ! Mathf.Approximately(0f, r2b.velocity.x);
        
        if(r2b.velocity.x < 0)
            transform.localScale = new Vector3(-1f, 1f, 1f);
        if(r2b.velocity.x > 0)
            transform.localScale = new Vector3(1f, 1f, 1f);
        jumping = ! Mathf.Approximately(0f, r2b.velocity.y);
        anim.SetBool("jumping", jumping);
        anim.SetFloat("vectory", r2b.velocity.y);
        if(!jumping)
            anim.SetBool("moving", moving);
    }

    public void HatOff()
    {
        anim.SetBool("HatOff", true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        setSpeed();
    }
}
