using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager GM;
    Door door;
    PlayerAnimator pla;
    GameObject player;

    private void Awake() {
        GM = this;
        door = FindObjectOfType<Door>();
        pla = FindObjectOfType<PlayerAnimator>();
        player = pla.gameObject;
    }

    public void EndGame()
    {
        
        GameMask.GMS.showAll();
        
    }

    public void resetPos()
    {
        pla.gameObject.transform.position = door.gameObject.transform.position;
    }

    public void EndGame2()
    {
        door.setDoor();
        pla.HatOff();
        BGM.bb.playWinSound();
        StartCoroutine(nextScene());
    }

    IEnumerator nextScene()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ResetLevel()
    {
        Debug.Log("lose");
        StartCoroutine(ResetLevelIE());
    }

    IEnumerator ResetLevelIE()
    {
        BGM.bb.playLoseSound();
        yield return new WaitForSeconds(.1f);
        player.GetComponent<PlayerAnimator>().enabled = false;
        player.GetComponent<PlayerController>().enabled = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.GetComponent<Rigidbody2D>().gravityScale = 0;
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
