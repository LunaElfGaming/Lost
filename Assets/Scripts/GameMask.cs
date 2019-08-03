using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMask : MonoBehaviour
{
    public static GameMask GMS;
    SpriteMask spm;
    public float deltaTimer;
    public int currentLayer;
    public int MaxLayer;
    float previousSet;

    IEnumerator showAllIE()
    {
        spm.backSortingOrder = spm.frontSortingOrder = 0;
        currentLayer = 0;
        for (int i = 1; i <= MaxLayer; i++)
        {
            spm.frontSortingOrder = i;
            yield return new WaitForSeconds(.3f);
        }
        spm.frontSortingOrder = MaxLayer;
        GameManager.GM.EndGame2();
    }

    public void showAll()
    {
        StartCoroutine(showAllIE());
    }

    IEnumerator setLayerIE(bool descent)
    {
        if (descent && spm.frontSortingOrder != MaxLayer)
        {
            spm.backSortingOrder = spm.backSortingOrder + 1;
        }

        if (!descent && spm.backSortingOrder != 0)
            spm.frontSortingOrder = spm.frontSortingOrder - 1;
        currentLayer = 0;
        yield return new WaitForSeconds(deltaTimer);
        if (descent && spm.frontSortingOrder != MaxLayer)
        {
            spm.frontSortingOrder = spm.frontSortingOrder + 1;
        }
        if (!descent && spm.backSortingOrder != 0)
        {
            spm.backSortingOrder = spm.backSortingOrder - 1;
        }
        currentLayer = spm.frontSortingOrder;
    }

    void setLayer(bool descent)
    {
        if (Time.time - previousSet > deltaTimer)
        {
            StartCoroutine(setLayerIE(descent));
            previousSet = Time.time;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        GMS = this;
        spm = GetComponent<SpriteMask>();
        if (spm.isCustomRangeActive == false)
            Debug.Log("ERROR OF MASK");
        spm.frontSortingOrder = 1;
        spm.backSortingOrder = 0;
        currentLayer = 1;
        previousSet = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            setLayer(false);
        if (Input.GetKeyDown(KeyCode.RightArrow))
            setLayer(true);
    }
}
