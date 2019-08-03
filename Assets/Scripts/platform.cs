using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<SpriteRenderer>().sortingOrder == GameMask.GMS.currentLayer)
        {
            if(Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector3(transform.position.x - speed*Time.deltaTime, transform.position.y, transform.position.z);
            }
            if(Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(transform.position.x + speed*Time.deltaTime, transform.position.y, transform.position.z);
            }
        }
        
    }
}
