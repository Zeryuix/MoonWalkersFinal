using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAnimation : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    
    private void Update()
    {
        if (CollisionFusee.crashed)
        {
            transition.SetBool("Crashed", true);
            LoadG();
        }
        else
        {
            transition.SetBool("Crashed", false);
        }
    }
    
    public void LoadG()
    {
        StartCoroutine(LoadGame());
    }
    
    IEnumerator LoadGame()
    {
        yield return new WaitForSeconds(transitionTime);
    } 
}
