using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CurrencyController : MonoBehaviour
{
    [SerializeField] ParticleSystem hitPs;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != PlayerController.i.gameObject) return;
        //gameObject.SetActive(false);
        hitPs.transform.parent = null;
        hitPs.Play();
        transform.DOMoveY(1.2f, 0.4f).SetRelative().SetEase(Ease.OutFlash, 2f);
        transform.DOScale(Vector3.zero, 0.3f).SetDelay(0.2f);
    }
}
