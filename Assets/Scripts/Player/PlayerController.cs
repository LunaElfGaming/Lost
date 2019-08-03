using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D r2b;
    public float moveForce;

    public Vector2 doorBound;
    

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
        if(Input.GetKeyDown(KeyCode.W))
        {
            checkDoor();
        }
    }

    void checkDoor()
    {
        GameObject door = FindObjectOfType<Door>().gameObject;
        Vector2 pos = door.transform.position;
        if(Mathf.Abs(pos.x - transform.position.x) < doorBound.x && Mathf.Abs(pos.y - transform.position.y) < doorBound.y)
        {
            GameManager.GM.EndGame();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "death")
        {
            GameManager.GM.ResetLevel();
        }
    }

    void Start()
    {
        r2b = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        playerInput();
    }
}
