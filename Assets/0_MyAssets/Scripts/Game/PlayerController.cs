using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum PlayerState
{
    Stop,
    Running,
    Crouching,
}


public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Animator animator;
    [NonSerialized] public PlayerState playerState;
    [NonSerialized] public float runningSpeed = 7f;
    public static PlayerController i;

    private void Awake()
    {
        i = this;
    }

    void Start()
    {
        playerState = PlayerState.Stop;
    }


    void Update()
    {
        animator.SetBool("IsRunning", playerState == PlayerState.Running);
        switch (playerState)
        {
            case PlayerState.Stop:
                if (Input.GetMouseButtonDown(0))
                {
                    playerState = PlayerState.Running;
                }
                break;
            case PlayerState.Running:
                if (Input.GetMouseButtonDown(0))
                {
                    playerState = PlayerState.Crouching;
                }
                break;
            case PlayerState.Crouching:
                if (Input.GetMouseButtonUp(0))
                {
                    playerState = PlayerState.Running;
                }
                break;
            default:
                break;
        }
    }

    private void FixedUpdate()
    {
        switch (playerState)
        {
            case PlayerState.Stop:
                rb.velocity = Vector3.zero;
                break;
            case PlayerState.Running:
                rb.velocity = Vector3.right * runningSpeed;
                break;
            case PlayerState.Crouching:
                rb.velocity = Vector3.zero;
                break;
            default:
                break;
        }
    }
}
