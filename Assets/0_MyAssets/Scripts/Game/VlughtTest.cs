using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class VlughtTest : MonoBehaviour
{
    [SerializeField] VLight vLight;
    void Start()
    {
        vLight.spotRange = 0;
        DOTween.To
        (
            () => vLight.spotRange,
            (x) => vLight.spotRange = x,
            10,
            5f
        ).SetEase(Ease.Linear);
    }


}
