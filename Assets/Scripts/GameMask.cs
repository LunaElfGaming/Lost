using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMask : MonoBehaviour
{
    SpriteMask spm;
    public float deltaTimer;
    int currentLayer;
    public int MaxLayer;
    float previousSet;

    IEnumerator setLayerIE(bool descent)
    {
        if (descent)
            spm.backSortingOrder = spm.backSortingOrder + 1;
        else
            spm.frontSortingOrder = spm.frontSortingOrder - 1;
        yield return new WaitForSeconds(deltaTimer);
        if(descent)
        {
            if(spm.frontSortingOrder == MaxLayer)
                spm.backSortingOrder = spm.backSortingOrder -1;
            else
                spm.frontSortingOrder = spm.frontSortingOrder +1;
        }
        else
        {
            if(spm.backSortingOrder == 0)
                spm.frontSortingOrder = spm.frontSortingOrder + 1;
            else
                spm.backSortingOrder = spm.backSortingOrder -1;
        }
    }

    void setLayer(bool descent)
    {
        if(Time.time - previousSet > deltaTimer)
        {
            StartCoroutine(setLayerIE(descent));
            previousSet = Time.time;
        }
            
    }

    // Start is called before the first frame update
    void Start()
    {
        spm = GetComponent<SpriteMask>();
        if (spm.isCustomRangeActive == false)
            Debug.Log("ERROR OF MASK");
        previousSet = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
            setLayer(false);
        if(Input.GetKeyDown(KeyCode.O))
            setLayer(true);
    }
}
