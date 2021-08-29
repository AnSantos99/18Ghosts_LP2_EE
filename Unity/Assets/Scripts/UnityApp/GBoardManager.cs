using System.Collections;
using UnityEngine;
//using Common;

public class GBoardManager : MonoBehaviour
{
    public bool invalidInput;
    public GameObject[] fadeObj;

    public bool draggedFromSlot;

    //Get Houses from Console board script
    //Get Houses from board on unity
    //ligado ao board do model script
    //cada tile devia, por exemplo, dzr as suas coordenadas
    //se fizeres click nele ou assim.
    //link the colors from the houses from console to unity

    //randomly place the diferent colored ghosts in their respective colors

    //have an action counter and sync it up with the console

    //Check portal rotation if ghost goe to dungeon

    // if the portal is turned to the ghost
    // the ghost dosent need to be in the portal to leave the board

    //If there r open houses, pull ghost out of dungeon
    //your opponent choses a house of the same color
    //or wait till one is free

    private void Update()
    {
        if (invalidInput)
        {
            StartCoroutine(WrongInput(true));
        }
    }

    IEnumerator WrongInput(bool fadeAway)
    {
        // fade from opaque to transparent
        if (invalidInput)
        {
            // Activate Obj
            invalidInput = false;
            fadeObj[0].SetActive(true);
            yield return new WaitForSeconds(1);
            fadeObj[0].SetActive(false);
        }
    }
}
