using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCharacter : MonoBehaviour
{
    [SerializeField] private GameObject samu, taneli;
    private int character;

    private void Awake()
    {
        character =  PlayerPrefs.GetInt("Character");
    }

    private void Start()
    {
        ShowRightCharacter();
    }

    private void ShowRightCharacter()
    {
        if (character == 0)
        {
            samu.SetActive(true);
        }
        else
        {
            taneli.SetActive(true);
        }
    }
}
