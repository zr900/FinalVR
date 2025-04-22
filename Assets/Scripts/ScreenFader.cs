using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenFader : MonoBehaviour
{
    public Image fadeImage;
    public float fadeDuration = 1.0f;

    public IEnumerator FadeOut()
    {
        float timer = 0f;
        Color color = fadeImage.color;
        while (timer < fadeDuration)
        {
            color.a = Mathf.Lerp(0f, 1f, timer / fadeDuration);
            fadeImage.color = color;
            timer += Time.deltaTime;
            yield return null;
        }
        color.a = 1f;
        fadeImage.color = color;
    }

    public IEnumerator FadeIn()
    {
        float timer = 0f;
        Color color = fadeImage.color;
        while (timer < fadeDuration)
        {
            color.a = Mathf.Lerp(1f, 0f, timer / fadeDuration);
            fadeImage.color = color;
            timer += Time.deltaTime;
            yield return null;
        }
        color.a = 0f;
        fadeImage.color = color;
    }

    public IEnumerator FadeRoutine(System.Action onFadeMidpoint)
    {
        yield return StartCoroutine(FadeOut());
        onFadeMidpoint?.Invoke();
        yield return StartCoroutine(FadeIn());
    }
}