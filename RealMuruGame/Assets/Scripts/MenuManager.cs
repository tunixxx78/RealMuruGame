using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
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
    }
    public void StartGameTaneli()
    {
        SceneManager.LoadScene(3);
    }
}
