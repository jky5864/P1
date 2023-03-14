using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using player;
using FoodSystem;
using TMPro;

public class Pan : MonoBehaviour
{
    public bool playerOn = false;
    private static string currentCooking = " ";
    private int workTime;
    private int CookatTurn;
    private int[] cookTime = new int[1];
    private bool finishPan;
    public TMP_Text info;
    public TMP_Text currentFood;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        controlThePan();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerOn = true;
        FoodStack.allControl = true;
        if (FoodStack.allControl)
        {
            currentFood.text = currentCooking;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerOn = false;
        FoodStack.allControl = false;
        if (!FoodStack.allControl)
        {
            currentFood.text = string.Empty;
        }
    }
    private void OnMouseEnter()
    {
        info.text = "This is Pan";
    }

    private void OnMouseExit()
    {
        info.text = string.Empty;
    }

    void controlThePan()
    {
        CookatTurn = Player.turns;
        if (playerOn == true && Input.GetKeyDown(KeyCode.Space))
        {

            if (finishPan && Player.pocket.Equals(" "))
            {
                Player.pocket = currentCooking;
                currentCooking = " ";
                finishPan = false;
            }

            if (Player.pocket.Equals(FoodStack.foodName[0]))
            {
                workTime = 5;
                CookatTurn = Player.turns + workTime;
                cookTime[0] = CookatTurn;
                Debug.Log(CookatTurn);
                currentCooking = FoodStack.foodName[0];
                Player.pocket = " ";
                Food.emptyPocket();
            }
            else if (Player.pocket.Equals(FoodStack.foodName[1]))
            {
                workTime = 10;
                CookatTurn = Player.turns + workTime;
                cookTime[0] = CookatTurn;
                Debug.Log(CookatTurn);
                currentCooking = FoodStack.foodName[1];
                Player.pocket = " ";
                Food.emptyPocket();
            }
            else
            {
                Debug.Log("You Cannot Do that");
                return;
            }

        }
        bool check = Player.turns.Equals(cookTime[0]);
        //Debug.Log(check);
        if (currentCooking.Equals(FoodStack.foodName[0]) && check)
        {
            Debug.Log(check);
            currentCooking = FoodStack.grilledFood[0];
            finishPan = true;
            cookTime[0] = 0;
            Debug.Log(currentCooking);
        }
        else if (currentCooking.Equals(FoodStack.foodName[1]) && check)
        {
            currentCooking = FoodStack.grilledFood[1];
            finishPan = true;
            cookTime[0] = 0;
            Debug.Log(currentCooking);
        }
    }
}
