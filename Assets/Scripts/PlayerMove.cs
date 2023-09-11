using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public VariableJoystick variableJoystick;
    public float MoveSpeed;
    private float moveSpeed { get => MoveSpeed; set => MoveSpeed = value; }

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontal = variableJoystick.Horizontal;
        float vertical = variableJoystick.Vertical;

        Vector3 moveDirection = new Vector3(horizontal, vertical).normalized;
        Vector3 newPosition = transform.position + moveDirection * moveSpeed * Time.deltaTime;
        newPosition.x = Mathf.Clamp(newPosition.x, -18.5f, 18.5f);
        newPosition.y = Mathf.Clamp(newPosition.y, -10f, 10f);
        transform.position = newPosition;
        Flip(horizontal);
        RunAnim(horizontal, vertical);
    }

    void Flip(float horizontal)
    {
        if (horizontal > 0) spriteRenderer.flipX = false;
        else if (horizontal < 0) spriteRenderer.flipX = true;
    }

    void RunAnim(float h, float v)
    {
        if(h != 0 || v != 0) animator.SetBool("IsMove", true);
        else animator.SetBool("IsMove", false);
    }
}
