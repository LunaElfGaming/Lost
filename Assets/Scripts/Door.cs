using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;

    private void Awake() {
        anim = GetComponent<Animator>();
        //anim.enabled = false;
    }

    public void setDoor()
    {
        anim.enabled = true;
    }
}
