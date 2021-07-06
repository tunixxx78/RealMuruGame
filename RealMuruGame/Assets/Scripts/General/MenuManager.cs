using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Animator taneliAnimator;
    public Animator SamuilAnimator;

    

    /*[SerializeField] private GameObject[] characters;
    //private int characterIndex;

    public void ChangeCharacter(int index)
    {
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetActive(false);
        }
        //this.characterIndex = index;
        characters[index].SetActive(true);
    }*/

    public void StartGameSamu()
    {
        //SceneManager.LoadScene(2);
        Invoke("LoadSamuScene", 2);
        SamuilAnimator.SetBool("Run", true);
        //PlayerPrefs.SetInt("CharacterIndex", characterIndex);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }
    public void StartGameTaneli()
    {
        //SceneManager.LoadScene(3);
        Invoke("LoadTaneliScene", 2);
        taneliAnimator.SetBool("Run", true);
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
