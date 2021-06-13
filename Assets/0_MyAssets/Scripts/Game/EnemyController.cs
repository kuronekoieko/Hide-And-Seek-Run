using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public enum EnemyState
{
    LookingAround,
    Holding
}

public class EnemyController : MonoBehaviour
{
    [SerializeField] EnemyAnimatorIK enemyAnimatorIK;
    [SerializeField] Animator animator;
    Vector3 offset;
    EnemyState enemyState;
    float timer;

    private void Start()
    {
        offset = transform.position - PlayerController.i.transform.position;
        enemyState = EnemyState.LookingAround;
        enemyAnimatorIK.weight = 0;
    }

    private void Update()
    {
        animator.SetBool("IsHolding", enemyState == EnemyState.Holding);
        switch (enemyState)
        {
            case EnemyState.LookingAround:
                timer += Time.deltaTime;

                if (timer > 3f)
                {
                    enemyState = EnemyState.Holding;
                    timer = 0f;
                    DOTween.To(() => enemyAnimatorIK.weight, (x) => enemyAnimatorIK.weight = x, 1f, 1.5f).
                    SetEase(Ease.InOutSine);
                }

                break;
            case EnemyState.Holding:

                break;
            default:
                break;
        }
    }

    private void LateUpdate()
    {
        transform.position = PlayerController.i.transform.position + offset;
    }
}
