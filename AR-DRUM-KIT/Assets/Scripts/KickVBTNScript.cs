using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class KickVBTNScript : MonoBehaviour, IVirtualButtonEventHandler
{
    VirtualButtonBehaviour[] virtualButtons;

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
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("...RELEASED...");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}