using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBinding : MonoBehaviour
{
    public GameObject keys;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameMask.GMS.currentLayer == GetComponent<SpriteRenderer>().sortingOrder)
        {
            keys.SetActive(true);
        }
        else
            keys.SetActive(false);
        
    }
}
