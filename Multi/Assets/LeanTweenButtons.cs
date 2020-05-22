using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LeanTweenButtons : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public UnityEvent onCompleteCallBack;
    public GameObject Button;
    public GameObject SelectionUI;
    public LeanTweenType isOutside;

    public void OnPointerEnter(PointerEventData eventData)
    {
        SelectionUI.SetActive(true);
        LeanTween.scale(Button, new Vector2(1.3f, 1.3f), 0.1f).setOnComplete(OnComplete);
        LeanTween.scale(SelectionUI, new Vector2(1.3f, 1.3f), 0.1f).setOnComplete(OnComplete);
        LeanTween.scale(Button, new Vector2(1.2f, 1.2f), 0.1f).setOnComplete(OnComplete).setDelay(0.1f);
        LeanTween.scale(SelectionUI, new Vector2(1.2f, 1.2f), 0.1f).setOnComplete(OnComplete).setDelay(0.1f);
    }

    public void OnComplete()
    {
        if(onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LeanTween.scale(Button, new Vector2(1f, 1f), 0.3f).setOnComplete(OnComplete);
        LeanTween.scale(SelectionUI, new Vector2(1f, 1f), 0.3f).setOnComplete(OnComplete);
        SelectionUI.SetActive(false);
    }
}
