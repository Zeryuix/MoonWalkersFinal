using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeanTweenAdjust : MonoBehaviour
{
    public UnityEvent onCompleteCallBack;
    public GameObject GameObject;
    void Start()
    {
        LeanTween.scale(GameObject, new Vector2(1f, 1f), 0).setOnComplete(OnComplete);
    }
    
    public void OnComplete()
    {
        if(onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }
}
