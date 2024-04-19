using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVertical : MonoBehaviour
{
    public float rotationAmount = 90f; 
    public float pauseDuration = 2f; 

    void Start()
    {
        
        RotateForward();
    }

    
    void RotateForward()
    {
        LeanTween.rotateAround(gameObject, Vector3.up, rotationAmount, pauseDuration)
            .setEase(LeanTweenType.easeInOutQuad)
            .setOnComplete(RotateBackward);
    }

    
    void RotateBackward()
    {
        LeanTween.rotateAround(gameObject, Vector3.up, -rotationAmount, pauseDuration)
            .setEase(LeanTweenType.easeInOutQuad)
            .setOnComplete(RotateForward);
    }

}
