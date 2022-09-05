using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WinOrLose : MonoBehaviour
{
    private EnvironmentHitPlayer EnvironmentHitPlayer1;
    private EnvironmentHitPlayer EnvironmentHitPlayer2;
    public GameObject player1;
    public GameObject player2;
    public GameObject status1;
    public GameObject status2;
    public List<GameObject> endButton;
    public bool SetArtifact = false;
    public int timing;


    Animator anim1,anim2;
    public GameObject anim1_Object,anim2_Object;

    private GameObject[] BG;
    private GameObject[] Tile;

    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        anim1 = anim1_Object.GetComponent<Animator>();
        anim2 = anim2_Object.GetComponent<Animator>();
        EnvironmentHitPlayer1 = player1.GetComponent<EnvironmentHitPlayer>();
        EnvironmentHitPlayer2 = player2.GetComponent<EnvironmentHitPlayer>();
        InvokeRepeating("timeCount", 0, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timing < 0)
        {
            timing = 40;
            SetArtifact = true;
        }
    }
    public void Lose(GameObject player)
    {
        stopTime();
        if (player.tag == "Player1")
        {
            Status1Lose();
            Status2Win();
            Anim1Lost();
            Anim2Win();

        }
        else if (player.tag == "Player2")
        {
            Status2Lose();
            Status1Win();
            Anim1Win();
            Anim2Lost();
        }
        endButton[0].SetActive(true);
        endButton[1].SetActive(true);
    
    }
    public void Win(GameObject player)
    {
        stopTime();
        if (player.tag == "Player1")
        {
            Status1Win();
            Status2Lose();
            Anim1Win();
            Anim2Lost();

        }
        else if (player.tag == "Player2")
        {
            Status2Win();
            Status1Lose();
            Anim1Lost();
            Anim2Win();
        }
        endButton[0].SetActive(true);
        endButton[1].SetActive(true);
    }
    public void Status1Lose()
    {
        status1.GetComponent<Text>().text = "Lose";
    }
    public void Status1Win()
    {
        status1.GetComponent<Text>().text = "Win";
    }
    public void Status2Lose()
    {
        status2.GetComponent<Text>().text = "Lose";
    }
    public void Status2Win()
    {
        status2.GetComponent<Text>().text = "Win";
    }
    public void Anim1Lost()
    {
        anim1.SetTrigger("Lose");
    }
    public void Anim1Win()
    {
        anim1.SetTrigger("Win");
    }
    public void Anim2Lost()
    {
        anim2.SetTrigger("Lost");
    }
    public void Anim2Win()
    {
        anim2.SetTrigger("Win");
    }
    void timeCount()
    {
        timing -= 1;
    }
    public void stopTime()
    {
        BG = GameObject.FindGameObjectsWithTag("BG");
        Tile = GameObject.FindGameObjectsWithTag("tile");

        for (int i = 0; i < BG.Length; i++)
        {
            BG[i].GetComponent<BGmove>().speed = 0;
        }
        for (int i = 0; i < Tile.Length; i++)
        {
            Tile[i].GetComponent<TileMove>().speed = 0;
        }
        Environment();
    }
    public void Environment()
    {
        EnvironmentHitPlayer1.CancelInvoke("iFrameAnimation");
        EnvironmentHitPlayer1.CancelInvoke("timeOutiFrame");
        EnvironmentHitPlayer2.CancelInvoke("iFrameAnimation");
        EnvironmentHitPlayer2.CancelInvoke("timeOutiFrame");
        EnvironmentHitPlayer1.knockBackDistant = 0;
        EnvironmentHitPlayer2.knockBackDistant = 0;
    }
}
