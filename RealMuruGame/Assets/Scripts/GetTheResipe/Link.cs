﻿using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenLink()
	{
		#if !UNITY_EDITOR
		openWindow("http://www.youtube.com");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}