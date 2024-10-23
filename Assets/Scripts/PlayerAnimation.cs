using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
   private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            animator.SetBool("IsWalking", true);
        }

        else
        {
            animator.SetBool("IsWalking", false);
        }

        if (Input.GetKey(KeyCode.W) && (Input.GetKey(KeyCode.S)))
        {
            animator.SetBool("IsWalking", false);
        }

        if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.D)))
        {
            animator.SetBool("IsWalking", false);
        }

        if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.W))))
        {
            animator.SetBool("IsWalking", true);
        }

        if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.S))))
        {
            animator.SetBool("IsWalking", true);
        }
    }
}
