using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeanTweenScaleUI : MonoBehaviour
{
    public UnityEvent onCompleteCallBack;
    public GameObject UI;

    void Start()
    {
        LeanTween.scale(UI, new Vector2(.9f, .9f), 1f).setOnComplete(OnComplete).setLoopPingPong();
    }

    public void OnComplete()
    {
        if (onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }
}
