using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
//using ConsoleApp.Model;

public class ActionHandler : MonoBehaviour
{

    public Image invInput;
    [SerializeField] private bool fade = false;

    private void Update()
    {
        if(fade)
        {
            StartCoroutine(FadeImage(true));
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag != this.gameObject.tag)
        {
            if (other.gameObject.tag == "Mirror")
            {
                //Link with Console script??
            }

            else if (other.gameObject.tag == "Portal")
            {
                //Link with Console script??
            }
        }
        else if (other.gameObject.tag == this.gameObject.tag)
        {
            //Invalid Input
            Debug.Log("Invalid Input");
        }
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                invInput.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                invInput.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }
}
