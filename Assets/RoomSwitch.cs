using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSwitch : MonoBehaviour
{
    public GameObject ChildRoom;
    public GameObject TeenRoom;
    private bool isInChildhood = true;

    public void SwitchRooms()
    {
        isInChildhood = !isInChildhood;
        ChildRoom.SetActive(isInChildhood);
        TeenRoom.SetActive(!isInChildhood);
    }
}
