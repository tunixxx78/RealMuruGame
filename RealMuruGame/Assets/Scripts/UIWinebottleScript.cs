using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWinebottleScript : MonoBehaviour
{
    private Animator animator;

    

    
    private void Awake()
    {
        animator = this.GetComponent<Animator>();
    }
    private void OnMouseEnter()
    {
        animator.SetBool("mouseOver", true);
    }
    private void OnMouseExit()
    {
        animator.SetBool("mouseOver", false);
    }
}
