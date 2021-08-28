using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GhostHouse : MonoBehaviour, IDropHandler
{
    //What is inside the square
    public GameObject obj;
    public GameObject resetObj;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");

        //If player is dragging something
        if (eventData.pointerDrag != null)
        {
            //If two different tags overlap
            if (obj.tag != eventData.pointerDrag.tag)
            {
                Debug.Log("Fight!");


                if (obj.tag == "Mirror")
                {

                    //Link with Console script??
                    Debug.Log("It be Mirror");

                }
                
                if (obj.tag == "Portal")
                {

                    //Link with Console script??
                    Debug.Log("It be Portal");
                }
                
                if (obj.tag == "Mirror")
                {

                    //Link with Console script??
                    Debug.Log("It be Mirror");
                }
            }

            else
            {

                //Invalid Input
                Debug.Log("invalid Input!");
            }

            if (this.gameObject.tag == "House")
            {
                //Debug.Log(this.gameObject.tag);

                obj = resetObj;
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;

                obj = eventData.pointerDrag; 
            }

            else if (this.gameObject.tag == "Mirror")
            {
                //Debug.Log(this.gameObject.tag);

                obj = resetObj;
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;

                obj = eventData.pointerDrag;
            }

            else if (this.gameObject.tag == "Portal")
            {
                //Debug.Log(this.gameObject.tag);

                obj = resetObj;
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;

                obj = eventData.pointerDrag;
            }


            //Debug.Log(eventData.pointerDrag.tag + obj.tag);
        }
        Debug.Log("Dropped object was: " + eventData.pointerDrag);
    }
}
