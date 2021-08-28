using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using ConsoleApp.Model;

public class ActionHandler : MonoBehaviour
{

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != this.gameObject.tag)
        {
            if(other.gameObject.tag == "Mirror")
            {
                //Link with Console script??
            }

            else if(other.gameObject.tag == "Portal")
            {
                //Link with Console script??
            }
        }
    }
}
