using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Animator taneliAnimator;
    public Animator SamuilAnimator;
    private int samu = 0;
    private int taneli = 1;


    public void StartGameSamu()
    {
        Invoke("LoadSamuScene", 2);
        SamuilAnimator.SetBool("Run", true);
        PlayerPrefs.SetInt("Character", samu);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }
    public void StartGameTaneli()
    {
        Invoke("LoadTaneliScene", 2);
        taneliAnimator.SetBool("Run", true);
        PlayerPrefs.SetInt("Character", taneli);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    private void LoadSamuScene()
    {
        SceneManager.LoadScene(2);
    }

    private void LoadTaneliScene()
    {
        SceneManager.LoadScene(3);
    }
}
