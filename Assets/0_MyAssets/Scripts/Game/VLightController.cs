using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VLightController : MonoBehaviour
{
    public static VLightController i;

    private void Awake()
    {
        i = this;
    }

    void Start()
    {
    }


    private void FixedUpdate()
    {
        if (PlayerController.i.playerState == PlayerState.Running)
        {
            // 何故かlateupdateでガタついたので
            transform.position += Vector3.right * Time.deltaTime * PlayerController.i.runningSpeed;
        }

    }
}
