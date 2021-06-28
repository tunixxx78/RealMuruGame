using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tableSceneTextScript : MonoBehaviour
{
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    

    public Animator animator;

    int buttonpresses = 0;
    public void changeText()
    {

        switch (buttonpresses)
        {
            case 0:
                text1.SetActive(false);
                text2.SetActive(true);
                buttonpresses++;
                break;
            case 1:
                animator.SetTrigger("transition");
                buttonpresses++;
                break;
            case 2:
                //GameObject.Find("GameManager").GetComponent<GameManager>().G
                //buttonpresses++;
                FindObjectOfType<GameManager>().GoToNextScene();
                break;


        }

       
    }

    //Called in from GreatJob script when all the items are in place
    public void WinTrigger()
    {
        text2.SetActive(false);
        text3.SetActive(true);
        animator.SetTrigger("win");
    }
}
