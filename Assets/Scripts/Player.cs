using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 0f;

    void Update()
    {
        transform.Translate(Vector3.right * 
            Input.GetAxis("Horizontal") * 
            moveSpeed * Time.deltaTime);
    }
}
