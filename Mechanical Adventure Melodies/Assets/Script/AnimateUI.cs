using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateUI : MonoBehaviour
{
    public GameObject logo;
    public GameObject fondoLogo;
    public GameObject botones;
    public GameObject botones2;
   

    void Start()
    {
        LeanTween.moveY(rectTrans: logo.GetComponent<RectTransform>(), to: 0, time: 1.5f).setEase(LeanTweenType.easeInBounce).setDelay(0.5f);

        LeanTween.alphaCanvas(fondoLogo.GetComponent<CanvasGroup>(), to: 0f, time: 1f).setDelay(3f);
    }

   
    public void ActivarBotones()
    {
        LeanTween.moveY(rectTrans: botones.GetComponent<RectTransform>(), to: 23f, time: 1.2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.moveY(rectTrans: botones2.GetComponent<RectTransform>(), to: 23f, time: 1.2f).setEase(LeanTweenType.easeOutElastic);
       
    }

  

}
