using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoonListingsMenu : MonoBehaviourPunCallbacks {


    [SerializeField]
    private Transform _content;
    [SerializeField]
    private RoomListing _roomListing;

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        //go through every single room list
        foreach (RoomInfo info in roomList)
        {
            //instantiate room list with content of player
            RoomListing listing = Instantiate(_roomListing, _content);
            //if list is not empty
            if(listing != null)
            {
                //give us the info on rooms
                listing.SetRoomInfo(info);
            }
        }
    }
}
