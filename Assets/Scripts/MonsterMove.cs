using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MonsterMove : MonoBehaviour
{
    public Transform target;
    public float MoveSpeed;
    private float moveSpeed { get => MoveSpeed; set => MoveSpeed = value; }
    private Rigidbody2D rigidBody;
    private SkeletonAnimation animator;
    private bool isChased = false;
    void Start()
    {
        target = FindAnyObjectByType<PlayerMove>().transform;
        animator = GetComponent<SkeletonAnimation>();
        rigidBody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        ChaseTarget();
    }

    void ChaseTarget()
    {
        if (target != null)
        {
            if(!isChased)
            {
                animator.AnimationState.SetAnimation(0, "Walk", true);
                isChased = true;
            }
            Vector3 targetDirection = (target.position - transform.position).normalized;

            transform.position += targetDirection * moveSpeed * Time.deltaTime;
        }
    }
}
