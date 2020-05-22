using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeanTweenPingPongUI : MonoBehaviour
{
    public GameObject UI;
    public UnityEvent onCompleteCallBack;
    
    void Start()
    {
        LeanTween.scale(UI, new Vector2(1f, 1f), 1f).setOnComplete(OnComplete).setLoopPingPong();
    }
    
    public void OnComplete()
    {
        if(onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }
}
