using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeanTweenScaleUI2 : MonoBehaviour
{
    public UnityEvent onCompleteCallBack;
    public GameObject UI;

    void Start()
    {
        LeanTween.scale(UI, new Vector2(.5f, .5f), 1f).setOnComplete(OnComplete).setLoopPingPong();
    }

    public void OnComplete()
    {
        if (onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }
}
