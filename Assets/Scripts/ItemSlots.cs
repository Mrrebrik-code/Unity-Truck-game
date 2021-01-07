using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemSlots : MonoBehaviour, IDropHandler
{
    private Vector2 _positoinSlots;
    [SerializeField] string figure;
    [SerializeField] float rotation1;
    [SerializeField] float rotation2;
    [SerializeField] private StartLevl gameManager;

    [Header("SFX")]
    [SerializeField] AudioClip drop;
    [SerializeField] AudioClip faill;
    [SerializeField] AudioSource audiosource;


    void Start()
    {
        _positoinSlots = GetComponent<RectTransform>().anchoredPosition;
    }


    public void OnDrop(PointerEventData eventData)
    {
        DragDrop _eventDataDragDrop = eventData.pointerDrag.GetComponent<DragDrop>();
        RectTransform _eventDataRectTransform = eventData.pointerDrag.GetComponent<RectTransform>();
        Debug.Log("ПРОСТО ДРОП");
        if (_eventDataDragDrop.figureID == figure &&
            (_eventDataDragDrop.currentRot == rotation1 ||
            _eventDataDragDrop.currentRot == rotation2 || _eventDataDragDrop.onDrop))
        {
            gameManager.count += 1;
            _eventDataRectTransform.anchoredPosition = _positoinSlots;
            _eventDataDragDrop.Left.SetActive(false);
            _eventDataDragDrop.Right.SetActive(false);
            _eventDataDragDrop.enabled = false;
            audiosource.PlayOneShot(drop);
            Debug.Log("ДА");

        }
        else
        {
            _eventDataRectTransform.anchoredPosition = _eventDataDragDrop._startPosition;
            audiosource.PlayOneShot(faill);
            _eventDataDragDrop.Left.SetActive(false);
            _eventDataDragDrop.Right.SetActive(false);
            _eventDataRectTransform.sizeDelta = _eventDataDragDrop._startScale;
            Debug.Log("НЕТ");
        }
    }
}
