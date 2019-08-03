using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour
{
    public GameObject childBlock;
    public float moveSpeed;
    public float rotateSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameMask.GMS.currentLayer == GetComponent<SpriteRenderer>().sortingOrder)
        {
            if(Input.GetKey(KeyCode.W))
            {
                transform.eulerAngles = new Vector3(.0f, .0f, transform.eulerAngles.z - rotateSpeed * Time.deltaTime);
                childBlock.transform.position = new Vector3(childBlock.transform.position.x, childBlock.transform.position.y+ moveSpeed * Time.deltaTime, childBlock.transform.position.z );
            }
            if(Input.GetKey(KeyCode.S))
            {
                transform.eulerAngles = new Vector3(.0f, .0f, transform.eulerAngles.z + rotateSpeed * Time.deltaTime);
                childBlock.transform.position = new Vector3(childBlock.transform.position.x, childBlock.transform.position.y- moveSpeed * Time.deltaTime, childBlock.transform.position.z );
            }
        }
        
    }
}
