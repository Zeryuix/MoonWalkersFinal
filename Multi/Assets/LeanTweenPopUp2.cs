using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeanTweenPopUp2 : MonoBehaviour
{
    public UnityEvent onCompleteCallBack;
    public GameObject UI;

    private void OnEnable()
    {
        transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(UI, new Vector3(2.1f, 2.1f, 2.1f), 0.3f).setDelay(0.3f).setOnComplete(OnComplete);
    }

    public void OnComplete()
    {
        if(onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }
}
