using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LeanTweenRotateUI : MonoBehaviour
{
    /*public UnityEvent onCompleteCallBack;
    public GameObject UI;
    
    void Start()
    {
        LeanTween.rotateAround(UI, Vector3.forward, 360, 2.5f).setOnComplete(OnComplete).setLoopClamp();
    }
    
    public void OnComplete()
    {
        if(onCompleteCallBack != null)
            onCompleteCallBack.Invoke();
    }*/
    
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, -0.5f));
    }
}
