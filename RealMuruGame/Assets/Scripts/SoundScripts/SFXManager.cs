using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource Audio;

    public AudioSource walk, hit, correctMove;

    public AudioClip button, bottle, jump;

    public static SFXManager sfxInsrtance;

    private void Awake()
    {
        if (sfxInsrtance != null && sfxInsrtance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        sfxInsrtance = this;
        DontDestroyOnLoad(this);
    }

    public void WalkSounds()
    {
        walk.Play();
    }
    public void TakeHit()
    {
        hit.Play();
    }
    public void CorrectMoveSound()
    {
        correctMove.Play();
    }
}
