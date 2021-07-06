using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private int samu = 0;
    private int taneli = 1;

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
        SceneManager.LoadScene(2);
        //PlayerPrefs.SetInt("CharacterIndex", characterIndex);
        PlayerPrefs.SetInt("Character", samu);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }
    public void StartGameTaneli()
    {
        SceneManager.LoadScene(3);
        PlayerPrefs.SetInt("Character", taneli);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }
}
