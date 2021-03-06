using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

/// <summary>
/// Unityで解像度に合わせて画面のサイズを自動調整する
/// http://www.project-unknown.jp/entry/2017/01/05/212837
/// </summary>
public class CameraController : MonoBehaviour
{
    public static CameraController i;
    Vector3 offset;

    private void Awake()
    {
        i = this;
    }

    private void Start()
    {
        offset = transform.position - PlayerController.i.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = PlayerController.i.transform.position + offset;
    }
}
