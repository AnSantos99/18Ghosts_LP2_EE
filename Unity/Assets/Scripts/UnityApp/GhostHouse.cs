using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GhostHouse : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");

        //If player is dragging something
        if (eventData.pointerDrag != null)
        {
            if (this.gameObject.tag == "House" || this.gameObject.tag == "DngHouse")
            {
                Debug.Log(this.gameObject.tag);

                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;
            }

            else if (this.gameObject.tag == "Mirror")
            {
                Debug.Log(this.gameObject.tag);

                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;
            }

            else if (this.gameObject.tag == "Portal")
            {
                Debug.Log(this.gameObject.tag);

                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;
            }
        }
        Debug.Log("Dropped object was: " + eventData.pointerDrag);
    }
}
