using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using TMPro;

public class CreateRoom : MonoBehaviourPunCallbacks {
    [SerializeField]
    private TMP_Text _roomName;

    public void OnClick_CreateRoom()
    {
        //CreateRoom

        //JoinOrCreateRoom
        if(!PhotonNetwork.IsConnected) 
            return;
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom(_roomName.text, options, TypedLobby.Default);
    }

    public override void OnCreatedRoom()
    {
        //MasterManager.DebugConsole.AddText("Created room successfully", this);
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        //MasterManager.DebugConsole.AddText("Room creation failed: " + message, this);
    }
}
