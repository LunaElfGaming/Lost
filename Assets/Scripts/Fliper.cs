using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fliper : MonoBehaviour
{
    public float startAngle;
    public float endAngle;
    public float timer;

    IEnumerator SetAngle(bool reverse)
    {
        float sa = reverse ? endAngle : startAngle;
        float ea = reverse ? startAngle : endAngle;
        float beginTie = Time.time;
        while (Time.time - beginTie <= timer)
        {
            transform.eulerAngles = new Vector3(.0f, .0f, sa + (ea - sa) * ((Time.time - beginTie) / timer));
            yield return null;
        }
        transform.eulerAngles = new Vector3(.0f, .0f, ea);
        yield return null;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
            StartCoroutine(SetAngle(false));
        if (Input.GetKeyDown(KeyCode.L))
            StartCoroutine(SetAngle(true));
    }
}
