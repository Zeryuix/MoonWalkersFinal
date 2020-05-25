using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoToMiddle : MonoBehaviour
{
    public GameObject UI;
    public UnityEvent onCompleteCallBack;
    
    public void MoveRight()
    {
        UI.transform.position = new Vector2(-793.25f, UI.transform.position.y);
        LeanTween.moveX(UI, 270, 0.3f).setOnComplete(OnComplete);
    }
    
    public void OnComplete()
    {
        if (onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }
}
