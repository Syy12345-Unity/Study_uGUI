using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class demo08_MouseOver : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler {
    [SerializeField] Image[] _outlineScaleX;
    [SerializeField] Image[] _outlineScaleY;
    [SerializeField] float _scaleDuration = 0.2f;
    [SerializeField] Ease _tweenEase;
    public void OnPointerEnter(PointerEventData eventData)
    {
        foreach (var outline in _outlineScaleX)
        {
            outline.transform.DOKill();
            outline.transform.DOScaleX(1,_scaleDuration).SetEase(_tweenEase).SetSpeedBased();
        }
        foreach (var outline in _outlineScaleY)
        {
            outline.transform.DOKill();
            outline.transform.DOScaleY(1, _scaleDuration).SetEase(_tweenEase).SetSpeedBased();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        foreach (var outline in _outlineScaleX)
        {
            outline.transform.DOKill();
            outline.transform.DOScaleX(0, _scaleDuration).SetEase(_tweenEase).SetSpeedBased();
        }
        foreach (var outline in _outlineScaleY)
        {
            outline.transform.DOKill();
            outline.transform.DOScaleY(0, _scaleDuration).SetEase(_tweenEase).SetSpeedBased();
        }
    }
}
