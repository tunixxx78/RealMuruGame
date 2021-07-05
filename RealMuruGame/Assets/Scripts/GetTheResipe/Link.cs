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

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

	

}