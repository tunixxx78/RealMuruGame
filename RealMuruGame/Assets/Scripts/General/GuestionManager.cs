using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuestionManager : MonoBehaviour
{
    [SerializeField] private GameObject menuBoard, starter, maincourse, desert, button1, rightAnswer, rightAnswer2, rightAnswer3, wrongAnswer, wineSelection, speechBubble;
    public Animator canvasAnimator;

    public void LetsPlay()
    {
        button1.SetActive(false);
        canvasAnimator.SetTrigger("firstSequence");
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
        /*menuBoard.SetActive(false);
        
        speechBubble.SetActive(false);
        starter.SetActive(true);
        wineSelection.SetActive(true);*/
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

    public void TryAgain()
    {
        speechBubble.SetActive(false);
        wrongAnswer.SetActive(false);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }
}
