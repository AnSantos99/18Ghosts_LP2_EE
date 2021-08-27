using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GhostHouse : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (this.gameObject.tag == "House")
        {
            Debug.Log("OnDrop");
            Debug.Log(this.gameObject.tag);

            if (eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
               //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;
            }
        }

        if (this.gameObject.tag == "Mirror")
        {
            if (eventData.pointerDrag != null)
            {
                Debug.Log(this.gameObject.tag);

                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;
            }
        }
        
        if (this.gameObject.tag == "Portal")
        {
            if (eventData.pointerDrag != null)
            {
                Debug.Log(this.gameObject.tag);

                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                //if droped somewhere out of bounds, tp to previous pos
                eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;
            }
        }
    }
}
