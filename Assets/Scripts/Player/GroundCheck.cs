using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkGround();
    }

    void checkGround()
    {
        Vector2 pos = new Vector2(0f, -0.6838782f);
        float radius = 0.2054076f;
        Collider2D[] cols = Physics2D.OverlapCircleAll(new Vector2(transform.position.x + pos.x, transform.position.y + pos.y), radius);
        //isGrounded = (cols.Length>1?true:false);
        bool found = true;
        foreach(var col in cols)
        {
            if(col.gameObject.tag == "platform")
            {
                transform.parent = col.transform;
                found = false;
            }
        }
        if(found)
            transform.parent = null;

    }
}
