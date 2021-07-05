using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chalkboardClickScript : MonoBehaviour
{
    public Animator CanvasAnimator;
    public GameObject alertIcon;
   

    private void OnMouseDown()
    {
        
        //brings up the UI canvas w/ animation
        CanvasAnimator.SetTrigger("click");
        

        //stops shaking animation
        this.GetComponent<Animator>().SetTrigger("click");
        alertIcon.SetActive(false);

        SFXManager.sfxInsrtance.Audio.PlayOneShot(SFXManager.sfxInsrtance.button);
    }
}
