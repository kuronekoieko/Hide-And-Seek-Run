using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - PlayerController.i.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = PlayerController.i.transform.position + offset;
    }
}
