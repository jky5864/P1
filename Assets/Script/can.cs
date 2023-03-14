using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using player;
public class can : MonoBehaviour
{
    // Start is called before the first frame update
    string playerProcket;
    bool playerOn = false;
    void Start()
    {
        playerProcket = Player.pocket;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerProcket != " "&& Input.GetKeyDown(KeyCode.Space)&& playerOn)
        {
            playerProcket = " ";
            Debug.Log("you put " + playerProcket + "into the can");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("enterTable");
        playerOn = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("ExitTable");
        playerOn = false;
    }
}
