using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomSwitch : MonoBehaviour
{
    public GameObject ChildRoom;
    public GameObject TeenRoom;
    public ScreenFader fader;

    private bool isInChildhood = true;

    public void SwitchRooms()
    {
        StartCoroutine(fader.FadeRoutine(() =>
        {
            isInChildhood = !isInChildhood;
            ChildRoom.SetActive(isInChildhood);
            TeenRoom.SetActive(!isInChildhood);
        }));
    }
}
