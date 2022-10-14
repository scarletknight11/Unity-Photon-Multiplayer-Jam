using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOrJoinRoomCanvas : MonoBehaviour {

    private RoomsCanvases _roomCanvases;

    public void Initialize(RoomsCanvases canvases) 
    {
        _roomCanvases = canvases;
    }
}
