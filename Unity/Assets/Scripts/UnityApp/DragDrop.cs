using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private GBoardManager bManageScript;
    public GameObject boardManager;

    [SerializeField] private Canvas canvas;
    private CanvasGroup canvasGroup;

    private RectTransform rectTransform;
    public Vector3 defaultPos;
    public bool droppedOnSlot;
    //public bool draggedFromSlot;


    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        bManageScript = boardManager.GetComponent<GBoardManager>();
    }

    private void Start()
    {
        defaultPos = transform.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("BeingDraged");
        canvasGroup.alpha = 0.6f;
        canvasGroup.blocksRaycasts = false;
        transform.SetAsLastSibling();
        //bManageScript.draggedFromSlot = true;
        droppedOnSlot = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("Drag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("EndDraged");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        //bManageScript.draggedFromSlot = false;

        //if droped somewhere out of bounds, tp to previous pos
        if (droppedOnSlot == false)
        {
            transform.position = defaultPos;
        }
    }
}
