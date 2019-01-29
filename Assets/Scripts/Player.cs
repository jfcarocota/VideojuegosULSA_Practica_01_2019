using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 0f;

    Animator anim;
    SpriteRenderer spr;

    float moveX;

    void Start()
    {
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * 
            moveX * 
            moveSpeed * Time.deltaTime);

        anim.SetFloat("MoveX", Mathf.Abs(moveX));

        spr.flipX = moveX < 0f ? true : moveX > 0f ? false : spr.flipX;
    }
}
