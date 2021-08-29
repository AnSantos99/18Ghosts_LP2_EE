using UnityEngine;
using UnityEngine.EventSystems;

public class GhostHouse : MonoBehaviour, IDropHandler
{
    //What is inside the square
    private GBoardManager bManageScript;
    public GameObject boardManager;
    public GameObject obj;
    public GameObject resetObj;


    private void Start()
    {
        bManageScript = boardManager.GetComponent<GBoardManager>();
    }

    private void Update()
    {if (bManageScript.draggedFromSlot == true)
        {
            Debug.Log("Reset");
            obj = resetObj;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("OnDrop");
        Debug.Log(eventData.pointerDrag.tag + obj.tag);

        if (eventData.pointerDrag.GetComponent<DragDrop>().transform.position != eventData.pointerDrag.GetComponent<DragDrop>().defaultPos)
        {
            bManageScript.draggedFromSlot = true;
        }
        //If player is dragging something
        if (eventData.pointerDrag != null)
        {

            //If the same tag overlaps
            if (obj.tag == eventData.pointerDrag.tag)
            {
                Debug.Log("Invalid Input!" + eventData.pointerDrag.tag + obj.tag);
                eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = false;
                eventData.pointerDrag.GetComponent<DragDrop>().transform.position = eventData.pointerDrag.GetComponent<DragDrop>().defaultPos;
                obj = eventData.pointerDrag;
                bManageScript.invalidInput = true;
            }

            //If two different tags overlap
            if (obj.tag != eventData.pointerDrag.tag)
            {
                Debug.Log("OnDrop" + eventData.pointerDrag.tag + obj.tag);

                if (obj.tag == "Mirror")
                {
                    //Debug.Log(this.gameObject.tag);

                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                    eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;
                    obj = eventData.pointerDrag;
                    //Link with Console script??
                    Debug.Log("It be Mirror");

                }

                else if (obj.tag == "Portal")
                {
                    //Debug.Log(this.gameObject.tag);

                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                    eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;

                    obj = eventData.pointerDrag;

                    //Link with Console script??
                    Debug.Log("It be Portal");
                }

                if (this.gameObject.tag == "House")
                {
                    Debug.Log(this.gameObject.tag);
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                    eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = true;
                    eventData.pointerDrag.GetComponent<DragDrop>().defaultPos = transform.position;

                    bManageScript.draggedFromSlot = false;

                    obj = eventData.pointerDrag;
                }
            }
        }
    }
}
