using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;
    Door door;
    PlayerAnimator pla;

    private void Awake() {
        GM = this;
        door = FindObjectOfType<Door>();
        pla = FindObjectOfType<PlayerAnimator>();
    }

    public void EndGame()
    {
        GameMask.GMS.showAll();
        
        
    }

    public void EndGame2()
    {
        door.setDoor();
        pla.HatOff();
    }

    public void ResetLevel()
    {
        Debug.Log("lose");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
