using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public static BGM bb;
    public AudioClip win;
    public AudioClip lose;
    public AudioSource BGmusic;

    private void Awake() {
        
        BGmusic = GetComponent<AudioSource>();
        if(bb == null)
        {
            bb=this;
            BGmusic.Play();
        }
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    public void playWinSound()
    {
        Debug.Log("WinSounding");
        BGmusic.PlayOneShot(win, 1f);
    }

    public void playLoseSound()
    {
        BGmusic.PlayOneShot(lose, 1f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
            playWinSound();
        if(Input.GetKeyDown(KeyCode.O))
            playLoseSound();
    }
}
