using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class LeanTweenButtons2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public UnityEvent onCompleteCallBack;
    public GameObject Button;
    public GameObject SelectionUI;
    public LeanTweenType isOutside;

    public void OnPointerEnter(PointerEventData eventData)
    {
        SelectionUI.SetActive(true);
        LeanTween.scale(SelectionUI, new Vector2(.1f, .1f), 0).setOnComplete(OnComplete); //Adjust
        LeanTween.scale(Button, new Vector2(1.5f, 1.5f), 0.1f).setOnComplete(OnComplete);
        
        LeanTween.scale(Button, new Vector2(2.5f, 2.5f), 0.1f).setOnComplete(OnComplete); //Animation
        LeanTween.scale(SelectionUI, new Vector2(.1f, .1f), 0.1f).setOnComplete(OnComplete);
        LeanTween.scale(Button, new Vector2(2f, 2f), 0.1f).setOnComplete(OnComplete).setDelay(0.1f);
        LeanTween.scale(SelectionUI, new Vector2(.09f, .09f), 0.1f).setOnComplete(OnComplete).setDelay(0.1f);
    }

    public void OnComplete()
    {
        if(onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        SelectionUI.SetActive(false);
        LeanTween.scale(Button, new Vector2(1.5f, 1.5f), 0.3f).setOnComplete(OnComplete);
        LeanTween.scale(SelectionUI, new Vector2(.1f, .1f), 0.3f).setOnComplete(OnComplete);
    }
}
