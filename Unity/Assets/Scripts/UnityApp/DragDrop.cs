using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
    //, IPointerDownHandler
{
    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;

    private RectTransform rectTransform;
    public Vector2 defaultPos;
    public bool droppedOnSlot;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
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
        transform.SetAsLastSibling();
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

        //if droped somewhere out of bounds, tp to previous pos
        if (droppedOnSlot == false)
        {
            transform.position = defaultPos;
        }
    }
}
