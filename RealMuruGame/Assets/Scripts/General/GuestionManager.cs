using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuestionManager : MonoBehaviour
{
    [SerializeField] private GameObject menuBoard, starter, maincourse, desert, button1, rightAnswer, rightAnswer2, rightAnswer3, wrongAnswer, wineSelection, speechBubble;

    public void LetsPlay()
    {
        menuBoard.SetActive(false);
        button1.SetActive(false);
        speechBubble.SetActive(false);
        starter.SetActive(true);
        wineSelection.SetActive(true);
    }

    public void ToQuestion2()
    {
        starter.SetActive(false);
        rightAnswer.SetActive(false);
        speechBubble.SetActive(false);
        maincourse.SetActive(true);
        wineSelection.SetActive(true);
        
    }

    public void ToQuestion3()
    {
        maincourse.SetActive(false);
        rightAnswer2.SetActive(false);
        speechBubble.SetActive(false);
        desert.SetActive(true);
        wineSelection.SetActive(true);
    }

    public void QuestionOneRight()
    {
        ToQuestion2();
    }
    public void QuestionTwoRight()
    {
        ToQuestion3();
    }
    public void QuestionThreeRight()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RightAnswer()
    {
        speechBubble.SetActive(true);
        rightAnswer.SetActive(true);
    }
    public void RightAnswer1()
    {
        speechBubble.SetActive(true);
        rightAnswer2.SetActive(true);
    }
    public void RightAnswer2()
    {
        speechBubble.SetActive(true);
        rightAnswer3.SetActive(true);
    }

    public void WrongAnswer()
    {
        speechBubble.SetActive(true);
        wrongAnswer.SetActive(true);
    }

    public void TryAgain()
    {
        speechBubble.SetActive(false);
        wrongAnswer.SetActive(false);
    }
}
