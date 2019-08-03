using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransitionImage : MonoBehaviour
{
    public Image transitionImage;
    [SerializeField] float speed = 2;
    public Color newColor;
    [SerializeField] bool doIt;
    [SerializeField] bool fadeOut = false;

    private void Update()
    {
        if (doIt)
        {
            if (fadeOut)
            {
                FadeOutTransition();
            }
            else
            {
                FadeInTransition();
            }
        }
    }

    void FadeInTransition()
    {
        float value = transitionImage.color.a;
        value -= Time.deltaTime * speed;
        newColor.a = value;
        transitionImage.color = newColor;
    }

    void FadeOutTransition()
    {
        float value = transitionImage.color.a;
        value += Time.deltaTime * speed;
        newColor.a = value;
        transitionImage.color = newColor;
    }
}
