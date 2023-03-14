using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facility : MonoBehaviour
{
    // Start is called before the first frame update
    public bool playerOn;
    public bool canStore;
    public bool isWorking;
    public int workTime;
    GameObject player = GameObject.Find("player");

    void Start()
    {
       
    }

}
