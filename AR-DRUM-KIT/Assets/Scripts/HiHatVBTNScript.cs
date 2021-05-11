using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class HiHatVBTNScript : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtons;
    public AudioSource hiHatSound;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("...START...");
        virtualButtons = GetComponentsInChildren<VirtualButtonBehaviour>();
        Debug.Log("virtualButtons.Length");
        foreach (VirtualButtonBehaviour virtualButton in virtualButtons)
        {
            virtualButton.RegisterEventHandler(this);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("...HI HAT IS BEING HIT...");
        playHiHat();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("...RELEASED...");
    }

    public void playHiHat(){ 
        hiHatSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}