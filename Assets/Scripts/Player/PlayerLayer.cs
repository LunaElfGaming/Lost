using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameMask.GMS.currentLayer == GetComponent<SpriteRenderer>().sortingOrder)
        {
            GetComponent<PlayerController>().enabled = true;
        }
        else
        {
            GetComponent<PlayerController>().enabled = false;
        }
    }
}
