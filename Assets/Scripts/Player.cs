using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Movement;

public class Player : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 0f;

    Animator anim;
    SpriteRenderer spr;

    float moveX;

    [SerializeField]
    AudioClip sfx_coin;

    AudioSource auds;

    void Start()
    {
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
        auds = GetComponent<AudioSource>();
    }

    void Update()
    {
        moveX = Movement.Axis.x;

        Movement.DeltaMovement(transform, moveSpeed);

        anim.SetFloat("MoveX", Mathf.Abs(moveX));

        spr.flipX = moveX < 0f ? true : moveX > 0f ? false : spr.flipX;
    }

    public void PlayCoinSFX()
    {
        auds.PlayOneShot(sfx_coin, 7f);
    }
}
