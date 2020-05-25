using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeanTweenMoveRight : MonoBehaviour
{
    public GameObject UI;
    public UnityEvent onCompleteCallBack;
    
    public void MoveRight()
    {
        LeanTween.moveX(UI, 2000, 0.3f).setOnComplete(OnComplete);
    }
    
    public void OnComplete()
    {
        if (onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }
}
