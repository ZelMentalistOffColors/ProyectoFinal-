using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScaler : MonoBehaviour
{
    public Vector3 minScale = new Vector3(2.0f, 2.0f, 2.0f); 
    public Vector3 maxScale = new Vector3(2.5f, 2.5f, 2.5f);
    public float duration = 0.6f; 

    private void Start()
    {
       
        ScaleButton(gameObject);
    }

    
    private void ScaleButton(GameObject button)
    {
        LeanTween.scale(button, maxScale, duration).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() =>
        {
            
            LeanTween.scale(button, minScale, duration).setEase(LeanTweenType.easeInOutQuad).setOnComplete(() =>
            {
                
                ScaleButton(button);
            });
        });
    }
}
