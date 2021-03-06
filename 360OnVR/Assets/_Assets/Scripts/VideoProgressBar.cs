﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoProgressBar : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    [SerializeField] private VideoPlayer videoPlayer;

    private Image progress;

    private void Awake()
    {
        progress = GetComponent<Image>();
        if (progress.fillAmount != 0)
        {
            progress.fillAmount = 0;
        }
    }

    private void Update()
    {
        if (videoPlayer.frameCount > 0)
        {
            progress.fillAmount = (float)videoPlayer.frame / (float)videoPlayer.frameCount;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    private void TrySkip(PointerEventData eventData)
    {
        Vector2 localPoint;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(progress.rectTransform,
            eventData.position,null,out localPoint))
        {
            float pct = Mathf.InverseLerp(progress.rectTransform.rect.xMin, 
                progress.rectTransform.rect.xMax, localPoint.x);
            SkipToPercent(pct);
        }
    }

    public void SkipToPercent(float pct)
    {
        //var frame = videoPlayer.frameCount * pct;
        //videoPlayer.frame = (long)frame;
        videoPlayer.frame = (long)pct;

        //0 - apresentação
        //400 - diferenciais
        //1040 - localização
        //1600 - segurança
        //2040 - administração
        //2390 - restaurante
        //2780 - estacionamento
        //3650 - mezanino
        //4130 - area interna
        //4500 - finalização
        //5400
    }
}
