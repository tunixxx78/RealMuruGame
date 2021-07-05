using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void GoToNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {

        Application.Quit();
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(1);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    

   
    //[SerializeField] private GameObject[] characterPrefabs;

    /*private void Start()
    {
        LoadCharacter();
    }
    public void LoadCharacter()
    {
        int characterIndex = PlayerPrefs.GetInt("CharacterIndex");
        //Instantiate(characterPrefabs[characterIndex]);
        
    }*/
}
