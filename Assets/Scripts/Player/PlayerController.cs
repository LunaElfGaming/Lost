using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D r2b;
    public float moveForce;

    void playerInput()
    {
        if(Input.GetKey(KeyCode.A))
        {
            r2b.AddForce(Vector2.left * moveForce);
        }
        if(Input.GetKey(KeyCode.D))
        {
            r2b.AddForce(Vector2.right*moveForce);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        r2b = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerInput();
    }
}
