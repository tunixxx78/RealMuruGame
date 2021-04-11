using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionsScreen : MonoBehaviour
{
    public GameObject moveOn, wrongA, rightA;

    public void WrongAnswer()
    {
        wrongA.SetActive(true);
    }

    public void RightAnswer()
    {
        rightA.SetActive(true);
        moveOn.SetActive(true);
    }

    public void TryAgain()
    {
        wrongA.SetActive(false);
    }
}
