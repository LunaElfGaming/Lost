using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear2 : MonoBehaviour
{
    public GameObject[] childGear;
    public float[] ie;
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
                rotateChild(1f);
            }
            if(Input.GetKey(KeyCode.S))
            {
                transform.eulerAngles = new Vector3(.0f, .0f, transform.eulerAngles.z + rotateSpeed * Time.deltaTime);
                rotateChild(-1f);
            }
        }
        
    }

    void rotateChild(float sign)
    {
        for(int i=0;i<childGear.Length;i++)
        {
            GameObject cob = childGear[i];
            cob.transform.eulerAngles = new Vector3(.0f, .0f, cob.transform.eulerAngles.z - sign * ie[i] * rotateSpeed * Time.deltaTime);
        }
    }
}
