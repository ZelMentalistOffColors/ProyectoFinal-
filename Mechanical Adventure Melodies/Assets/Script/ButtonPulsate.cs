using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPulsate : MonoBehaviour
{
    public float scaleAmount = 1.2f;
    public float duration = 0.5f;
    public float pauseDuration = 3f;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
        StartCoroutine(PulsateLoop());
    }

    IEnumerator PulsateLoop()
    {
        while (true)
        {
            LeanTween.scale(gameObject, originalScale * scaleAmount, duration).setEase(LeanTweenType.easeInOutQuad);
            yield return new WaitForSeconds(duration);

            LeanTween.scale(gameObject, originalScale, duration).setEase(LeanTweenType.easeInOutQuad);
            yield return new WaitForSeconds(duration);

            yield return new WaitForSeconds(pauseDuration);
        }
    }
}
