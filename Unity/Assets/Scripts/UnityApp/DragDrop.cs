using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;

    private RectTransform rectTransform;
    public Vector3 defaultPos;
    public bool droppedOnSlot;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        defaultPos = transform.position;
    }

    private void Start()
    {
        defaultPos = transform.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BeingDraged");
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
        eventData.pointerDrag.GetComponent<DragDrop>().droppedOnSlot = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDraged");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;

        if (droppedOnSlot == false)
        {
            transform.position = defaultPos;
        }

    }
    public void OnPointerDown (PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }

    public void OnDrop(PointerEventData eventData)
    {

        Debug.Log("OnDrop Item");
    }
}
