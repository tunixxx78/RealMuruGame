using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tableSceneTextScript : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    bool win = false;

    public Animator animator;
    public void changeText()
    {
        if (text2.activeInHierarchy)
        {
            animator.SetTrigger("transition");
            if (win)
            {
                animator.SetTrigger("win");
                text2.SetActive(false);
            }
            win = true;
        }

        text1.SetActive(false);

        text2.SetActive(true);

        
    }
}
