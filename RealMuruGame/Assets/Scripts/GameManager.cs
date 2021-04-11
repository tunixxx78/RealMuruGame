using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToAdvertisement()
    {
        SceneManager.LoadScene(5);
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
