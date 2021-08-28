using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GhostHouse : MonoBehaviour, IDropHandler
{
    public GameObject obj;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");

        //If player is dragging something
        if (eventData.pointerDrag != null)
        {
            //If two different tags overlap
            if (obj.tag != eventData.pointerDrag.tag)
            {
                Debug.Log("Overlap!");
            }

            Debug.Log(eventData.pointerDrag.tag + obj.tag);

            if (this.gameObject.tag == "House" || this.gameObject.tag == "DngHouse")
            {
                //Debug.Log(this.gameObject.tag);

                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;

                obj = eventData.pointerDrag; 
            }

            else if (this.gameObject.tag == "Mirror")
            {
                //Debug.Log(this.gameObject.tag);

                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;

                obj = eventData.pointerDrag;
            }

            else if (this.gameObject.tag == "Portal")
            {
                //Debug.Log(this.gameObject.tag);

                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;

                obj = eventData.pointerDrag;
            }


            Debug.Log(eventData.pointerDrag.tag + obj.tag);
        }
        //Debug.Log("Dropped object was: " + eventData.pointerDrag);
    }
}
