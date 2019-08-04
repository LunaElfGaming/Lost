using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnd : MonoBehaviour
{
    Animator anim;

    private void Awake() {
        anim = gameObject.GetComponent<Animator>();
    }

    IEnumerator ending()
    {
        float timer = 2f;
        float speed = -transform.position.x/timer;
        anim.SetBool("moving", true);
        while(transform.position.x < 0)
        {
            transform.position = new Vector3(transform.position.x + speed*Time.deltaTime, transform.position.y, 0f);
            yield return null;
        }
        anim.SetBool("moving", false);
        anim.SetBool("HatOff", true);
        yield return null;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ending());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
