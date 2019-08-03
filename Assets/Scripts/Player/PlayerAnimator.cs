using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    bool moving;
    Animator anim;
    Rigidbody2D r2b;

    private void Awake() {
        anim = GetComponent<Animator>();
        r2b = GetComponent<Rigidbody2D>();
    }

    void setSpeed()
    {
        moving = ! Mathf.Approximately(0f, r2b.velocity.x);
        anim.SetBool("moving", moving);
        if(r2b.velocity.x < 0)
            transform.localScale = new Vector3(-1f, 1f, 1f);
        else
            transform.localScale = new Vector3(1f, 1f, 1f);
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
    void Update()
    {
        setSpeed();
    }
}
