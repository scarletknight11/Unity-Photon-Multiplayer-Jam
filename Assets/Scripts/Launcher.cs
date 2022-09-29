using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class Launcher : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField roomNameInputField;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connecting to Master");
        //Establish connection with master server
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        MenuManager.instance.OpenMenu("TitleMenu");
        Debug.Log("Joined Lobby");
    }

    //launch room and have server load room
    public void CreateRoom()
    {
        if(string.IsNullOrEmpty(roomNameInputField.text))
        {
            return;
        }
        PhotonNetwork.CreateRoom(roomNameInputField.text);
        //stop server from taking up time
        MenuManager.instance.OpenMenu("loading");
    }

    //Room Created/joined
    public override void OnJoinedRoom()
    {
         
    }

    //if failed to join room
    public override void OnCreateRoomFailed(short returnCode, string message)
    {

    }
}
