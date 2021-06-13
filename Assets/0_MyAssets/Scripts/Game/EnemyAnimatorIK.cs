using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyAnimatorIK : MonoBehaviour
{
    [SerializeField] Transform rightHandTransform;
    private Animator animator;
    [NonSerialized] public float weight = 1;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnAnimatorIK()
    {
        animator.SetIKPositionWeight(AvatarIKGoal.RightHand, weight);
        animator.SetIKRotationWeight(AvatarIKGoal.RightHand, weight);
        animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandTransform.position);
        animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandTransform.rotation);
    }
}
