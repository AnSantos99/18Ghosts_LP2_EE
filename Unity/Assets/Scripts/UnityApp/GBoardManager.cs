using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GBoardManager : MonoBehaviour
{
    public Image invInput;
    [SerializeField] private bool fade = false;

    //Get Houses from Console board script
    //Get Houses from board on unity
    //ligado ao board do model script
    //cada tile devia, por exemplo, dzr as suas coordenadas
    //se fizeres click nele ou assim.
    //link the colors from the houses from console to unity

    private void Update()
    {
        if (fade)
        {
            StartCoroutine(FadeImage(true));
        }
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        // fade from opaque to transparent
        if (fadeAway)
        {
            // loop over 1 second backwards
            for (float i = 1; i <= 0; i -= Time.deltaTime)
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
            for (float i = 0; i >= 1; i += Time.deltaTime)
            {
                // set color with i as alpha
                invInput.color = new Color(1, 1, 1, i);
                yield return null;
            }
        }
    }
}
