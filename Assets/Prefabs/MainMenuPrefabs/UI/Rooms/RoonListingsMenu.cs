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

    private List<RoomListing> _listings = new List<RoomListing>();

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        //go through every single room list
        foreach (RoomInfo info in roomList)
        {
            //set to true if room is removed from list
            if (info.RemovedFromList)
            {
                int index = _listings.FindIndex(x => x.RoomInfo.Name == info.Name);
                if(index != -1)
                {
                    Destroy(_listings[index].gameObject);
                    _listings.RemoveAt(index);
                }
            } 
            //Added to rooms list
            else
            {
                //instantiate room list with content of player
                RoomListing listing = Instantiate(_roomListing, _content);
                //if list is not empty
                if (listing != null)
                {
                    //give us the info on rooms
                    listing.SetRoomInfo(info);
                }
            }
          
        }
    }
}
