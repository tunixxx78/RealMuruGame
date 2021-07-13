using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenLink()
	{
		#if !UNITY_EDITOR
		openWindow("http://www.murudining.fi");
		#endif
		SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
	}

	public void GoTo()
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

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

	

}