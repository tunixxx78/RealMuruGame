using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    [SerializeField] private GameObject howTo;
	public void QuitThisGame()
    { 
    #if (UNITY_EDITOR || DEVELOPMENT_BUILD)
    
#endif
#if (UNITY_EDITOR)
    UnityEditor.EditorApplication.isPlaying = false;
#elif (UNITY_STANDALONE)
    Application.Quit();
#elif (UNITY_WEBGL)
    Application.OpenURL("https://murudining.fi/");
#endif
    }

    public void HowToPlay()
    {
        howTo.SetActive(true);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }

    public void ExitHowToPlay()
    {
        howTo.SetActive(false);
        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }
}
