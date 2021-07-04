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
        gameObject.SetActive(false);
        hitPs.transform.parent = null;
        hitPs.Play();
    }
}
