using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeanTweenMoveXUI : MonoBehaviour
{
    public UnityEvent onCompleteCallBack;
    public GameObject UI;

    void Start()
    {
        LeanTween.moveX(UI, 975, 1f).setOnComplete(OnComplete).setLoopPingPong();
    }

    public void OnComplete()
    {
        if (onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }
}
