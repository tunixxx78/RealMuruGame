using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowControllers : MonoBehaviour
{
    public Animator mobileControlsAnimator;

    public void ShowButtons()
    {
        mobileControlsAnimator.SetTrigger("Show");
    }
}
