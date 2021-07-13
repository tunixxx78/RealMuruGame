using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuestionManager : MonoBehaviour
{
    [SerializeField] private GameObject menuBoard, starter, maincourse, desert, button1, rightAnswer, rightAnswer2, rightAnswer3, wrongAnswer, wrongAnswer2, wrongAnswer3, wineSelection, speechBubble,
        question1, question2, question3;
    public Animator canvasAnimator;

    public void LetsPlay()
    {
        button1.SetActive(false);
        canvasAnimator.SetTrigger("firstSequence");
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void ToQuestion2()
    {
        canvasAnimator.SetTrigger("secondSequence");
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
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }
    public void QuestionTwoRight()
    {
        ToQuestion3();
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }
    public void QuestionThreeRight()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void RightAnswer()
    {
        speechBubble.SetActive(true);
        rightAnswer.SetActive(true);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }
    public void RightAnswer1()
    {
        speechBubble.SetActive(true);
        rightAnswer2.SetActive(true);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }
    public void RightAnswer2()
    {
        speechBubble.SetActive(true);
        rightAnswer3.SetActive(true);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void WrongAnswer()
    {
        speechBubble.SetActive(true);
        wrongAnswer.SetActive(true);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void WrongAnswer2()
    {
        speechBubble.SetActive(true);
        wrongAnswer2.SetActive(true);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void WrongAnswer3()
    {
        speechBubble.SetActive(true);
        wrongAnswer3.SetActive(true);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void TryAgain()
    {
        speechBubble.SetActive(false);
        wrongAnswer.SetActive(false);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void TryAgainTwo()
    {
        speechBubble.SetActive(false);
        wrongAnswer2.SetActive(false);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void TryAgainThree()
    {
        speechBubble.SetActive(false);
        wrongAnswer3.SetActive(false);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void WrongOne()
    {
        question1.SetActive(true);
    }

    public void WrongTwo()
    {
        question2.SetActive(true);
    }

    public void WrongThree()
    {
        question3.SetActive(true);
    }
}
