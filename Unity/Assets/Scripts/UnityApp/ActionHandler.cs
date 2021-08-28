using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//using ConsoleApp.Model;

public class ActionHandler : MonoBehaviour
{

    public void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag != this.gameObject.tag)
        {
            if (other.gameObject.tag == "Mirror")
            {
                //Link with Console script??
                Debug.Log("It be Mirror");
            }

            else if (other.gameObject.tag == "Portal")
            {
                //Link with Console script??
                Debug.Log("It be Portal");
            }
        }
        if (this.gameObject.tag == other.gameObject.tag)
        {
            //Invalid Input
            Debug.Log("Invalid Input");
        }
    }
}
