using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeControl : MonoBehaviour
{

    public float fadeDuration = 1f;

    private Image FadeObject;
    private Color originalColor;

    private Coroutine coroutine;

    void Awake()
    {
        FadeObject = GetComponent<Image>();
        if (FadeObject == null)
        {
            Debug.Log("Bror ma en loyda tata FadeObjectia");
            return;
        }

        originalColor = FadeObject.color;
    }

    private void StartFade(float targetAlpha)
    {
        if (coroutine != null)
        {
            StopCoroutine(FadeRoutine(targetAlpha));
        }
        coroutine = StartCoroutine(FadeRoutine(targetAlpha));
    }

    private IEnumerator FadeRoutine(float targetAlpha)
    {
        float time = 0f;
        float startAlpha = FadeObject.color.a;

        while (time < fadeDuration)
        {
            time += Time.deltaTime;

            Color colorChange = FadeObject.color;
            float t = time / fadeDuration;
            colorChange.a = Mathf.Lerp(startAlpha, targetAlpha, t);
            FadeObject.color = colorChange;

            yield return null;
        }
    }
    Color final = fadeObject.color;
    final.a = targetAlpha;
    FadeObject.color = final;

}