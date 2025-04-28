using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class RoomSwitch : MonoBehaviour
{
    public GameObject childRoom;    // Reference to the ChildRoom
    public GameObject teenRoom;     // Reference to the TeenRoom
    public XRGrabInteractable grabInteractable;  // 3DS object (Child3DS or Teen3DS)
    
    private void Start()
    {
        // Set the initial room to be active
        childRoom.SetActive(true);
        teenRoom.SetActive(false);
    }

    // Method to switch rooms
    public void SwitchRoom()
    {

        Debug.Log("switcher");
        Debug.Log(childRoom.activeSelf);

        // Toggle the active rooms
        if (childRoom.activeSelf)
        {
            childRoom.SetActive(false);
            teenRoom.SetActive(true);
        }
        else
        {
            childRoom.SetActive(true);
            teenRoom.SetActive(false);
        }
    }

    // Call this method when the 3DS is grabbed
    public void OnGrabbed()
    {
        SwitchRoom();
    }
}


