using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeenTweenAdjust2 : MonoBehaviour
{
    public UnityEvent onCompleteCallBack;
    public GameObject GameObject;
    void Start()
    {
        LeanTween.scale(GameObject, new Vector2(2f, 2f), 0).setOnComplete(OnComplete);
    }
    
    public void OnComplete()
    {
        if(onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }
}
