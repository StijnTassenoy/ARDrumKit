using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class KickVBTNScript : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtons;
    public AudioSource kickSound;

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
        Debug.Log("...KICK IS BEING KICKED...");
        playKick();
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("...RELEASED...");
    }

    public void playKick(){ 
        kickSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}