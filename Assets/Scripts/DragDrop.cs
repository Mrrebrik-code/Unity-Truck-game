using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour,
    IPointerDownHandler,
    IBeginDragHandler,
    IEndDragHandler,
    IDragHandler,
    IDropHandler
{

    [SerializeField]RectTransform recTransform;
    [SerializeField] Canvas canvas;
    [SerializeField]CanvasGroup canvasGroup;

    public Vector2 _startPosition;
    public Vector2 _startScale;
    private Vector2 _normalScale;

    [SerializeField] Image figureScale;
    public GameObject Left;
    public GameObject Right;
    public string figureID;


    private void Awake()
    {   
        recTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        _startPosition = recTransform.anchoredPosition;
        _startScale = recTransform.sizeDelta;
        _normalScale = figureScale.GetComponent<RectTransform>().sizeDelta;

    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        recTransform.sizeDelta = _normalScale;
        Left.SetActive(true);
        Right.SetActive(true);
        Debug.Log(recTransform.rotation.z);
    }

    public void OnDrag(PointerEventData eventData)
    {
        recTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnDrop(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void RightRotButton()
    {
        Quaternion target = recTransform.rotation;
        recTransform.rotation = target * Quaternion.Euler(new Vector3(0, 0, -90));
        //Right.transform.rotation = Right.transform.rotation * Quaternion.Euler(new Vector3(0, 0, -90));
    }
    public void LeftRotButton()
    {
        Quaternion target = recTransform.rotation;
        recTransform.rotation = target * Quaternion.Euler(new Vector3(0, 0, 90));
        //Left.transform.rotation = Left.transform.rotation * Quaternion.Euler(new Vector3(0, 0, 90));
    }
}
