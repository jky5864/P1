using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStage : MonoBehaviour
{

    public int stage = 1;
    public GameObject player;
    public GameObject Turns;
    public GameObject Image;
    void Start()
    {
        player = GameObject.Find("Player");
        player.SetActive(false);
        Image.SetActive(false);
        Turns.SetActive(false);
    }

   
    void Update()
    {
        if(stage == 1 && Input.GetKeyDown(KeyCode.Space))
        {

            Image.SetActive(true);
            Turns.SetActive(true);
            Debug.Log("playerSpawn");
            player.SetActive(true);
            stage = 2;
        }
        if(stage == 2)
        {

        }
    }
}
